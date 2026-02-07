using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NekoBotV1.DataBase;
using Org.BouncyCastle.Security;

namespace NekoBotAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImagesController(IServiceProvider services) : ControllerBase
	{
		private readonly Random random = new();
		private readonly string _baseUrl = "https://api.nekobot.ca/v1";

		[Route("otto")]
		[HttpGet]
		public Task<string> Otto()
		{
			return DBFetchImages(ImageCategory.Otto);
		}

		[Route("kitsune")]
		[HttpGet]
		public Task<string> Kitsune()
		{
			return DBFetchImages(ImageCategory.Kitsune);
		}

		[Route("neko")]
		[HttpGet]
		public Task<string> Neko()
		{
			return DBFetchImages(ImageCategory.Neko);
		}

		[Route("tsuma")]
		[HttpGet]
		public Task<string> Tsuma()
		{
			return DBFetchImages(ImageCategory.Tsuma);
		}

		private async Task<string> DBFetchImages(ImageCategory image)
		{
			using var scope = services.CreateScope();
			using var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();

			var results = db.Images.Where(X => X.ImageCategory == image);

			if (!results.Any())
			{
				return "No Results Found";
			}

			var number = random.Next (await results.CountAsync());
			var result = await results.ElementAtAsync(number);

			return $"{_baseUrl}/{result.Location}/{result.Filename}";
		}
	}
}


//var/www/api.nekobot.ca/v1/images/neko/38250.gif