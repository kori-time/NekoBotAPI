using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NekoBotV1.API.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ActionsController : ControllerBase
	{
		[HttpGet]
		public Task<string> Actions()
		{
			return Task.FromResult("Random BS");
		}
	}
}