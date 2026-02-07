using Microsoft.EntityFrameworkCore;
using NekoBotV1.Core;
using NekoBotV1.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var settings = await Settings.LoadAsync();
if (settings is null)
{
	Console.WriteLine("All you nyans are mine! (config.json created!)");
	return;
}

builder.Services.AddDbContext<DatabaseContext>(opt => {
	 var connectionString = settings.ConnectionString(out DatabaseProvider provider);

	 switch (provider)
	 {
		 case DatabaseProvider.MySQL:
			 opt.UseMySQL(connectionString);
			 break;
		 case DatabaseProvider.PostgreSQL:
			 opt.UseNpgsql(connectionString);
			 break;
		 default:
			 throw new ArgumentException("Provider can only be \"mysql\" or \"pgsql\"!");
	 }
	 opt.EnableSensitiveDataLogging()
		 .UseLazyLoadingProxies();
 }, ServiceLifetime.Transient);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
