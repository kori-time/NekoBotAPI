using Microsoft.AspNetCore.Mvc;
using NekoBotAPI.Models;
using NekoBotV1.DataBase;

namespace NekoBotAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImagesController(DatabaseContext db) : NekoBotControllerBase(db)
	{
        [Route("otto")]
        [HttpGet]
        public Task<ImageResult> Otto() => DBFetchImagesAsync(ImageCategory.Otto);

        [Route("kitsune")]
        [HttpGet]
        public Task<ImageResult> Kitsune() => DBFetchImagesAsync(ImageCategory.Kitsune);

        [Route("neko")]
        [HttpGet]
        public Task<ImageResult> Neko() => DBFetchImagesAsync(ImageCategory.Neko);

        [Route("tsuma")]
        [HttpGet]
        public Task<ImageResult> Tsuma() => DBFetchImagesAsync(ImageCategory.Tsuma);
    }
}