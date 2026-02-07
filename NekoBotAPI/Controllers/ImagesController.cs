using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NekoBotAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
	{
		[HttpGet]
		public Task<string> Images()
		{
			return Task.FromResult("Random BS Blab");
		}
	}
}