using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NekoBotAPI.Models;
using NekoBotV1.DataBase;

namespace NekoBotAPI.Controllers
{
    public abstract class NekoBotControllerBase(IServiceProvider services) : ControllerBase
    {
		private readonly Random random = new();
		private readonly string _baseUrl = "https://api.nekobot.ca/v1";

		protected async Task<ImageResult> DBFetchImagesAsync(ImageCategory imageCategory)
		{
			using var scope = services.CreateScope();
			using var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();

			var results = db.Images.Where(X => X.ImageCategory == imageCategory);

			if (!results.Any())
				return ImageResult.FromEmpty();

			var number = random.Next(await results.CountAsync());
			var result = await results.ElementAtAsync(number);

			var imageresult = ImageResult.FromSuccess($"{_baseUrl}/{result.Location}/{result.Filename}", imageCategory);
			return imageresult;
		}
	}
}
