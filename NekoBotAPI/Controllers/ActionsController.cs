using Microsoft.AspNetCore.Mvc;
using NekoBotAPI.Models;
using NekoBotV1.DataBase;

namespace NekoBotAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ActionsController(DatabaseContext db) : NekoBotControllerBase(db)
	{
		[Route("ikari")]
		[HttpGet]
		public Task<ImageResult> Ikari() => DBFetchImagesAsync(ImageCategory.Ikari);

		[Route("baka")]
		[HttpGet]
		public Task<ImageResult> Baka() => DBFetchImagesAsync(ImageCategory.Baka);

		[Route("kamu")]
		[HttpGet]
		public Task<ImageResult> Kamu() => DBFetchImagesAsync(ImageCategory.Kamu);

		[Route("akameru")]
		[HttpGet]
		public Task<ImageResult> Akameru() => DBFetchImagesAsync(ImageCategory.Akameru);

		[Route("Taikutsu")]
		[HttpGet]
		public Task<ImageResult> Taikutsu() => DBFetchImagesAsync(ImageCategory.Taikutsu);

		[Route("naku")]
		[HttpGet]
		public Task<ImageResult> Naku() => DBFetchImagesAsync(ImageCategory.Naku);

		[Route("daki")]
		[HttpGet]
		public Task<ImageResult> Daki() => DBFetchImagesAsync(ImageCategory.Daki);

		[Route("odoru")]
		[HttpGet]
		public Task<ImageResult> Odoru() => DBFetchImagesAsync(ImageCategory.Odoru);

		[Route("gakkari")]
		[HttpGet]
		public Task<ImageResult> Gakkari() => DBFetchImagesAsync(ImageCategory.Gakkari);

		[Route("taberu")]
		[HttpGet]
		public Task<ImageResult> Taberu() => DBFetchImagesAsync(ImageCategory.Taberu);

		[Route("tetsunagi")]
		[HttpGet]
		public Task<ImageResult> TeTsunagi() => DBFetchImagesAsync(ImageCategory.TeTsunagi);

		[Route("akushu")]
		[HttpGet]
		public Task<ImageResult> Akushu() => DBFetchImagesAsync(ImageCategory.Akushu);

		[Route("ureshii")]
		[HttpGet]
		public Task<ImageResult> Ureshii() => DBFetchImagesAsync(ImageCategory.Ureshii);

		[Route("haifai")]
		[HttpGet]
		public Task<ImageResult> Haifai() => DBFetchImagesAsync(ImageCategory.Haifai);

		[Route("hagu")]
		[HttpGet]
		public Task<ImageResult> Hagu() => DBFetchImagesAsync(ImageCategory.Hagu);

		[Route("keru")]
		[HttpGet]
		public Task<ImageResult> Keru() => DBFetchImagesAsync(ImageCategory.Keru);

		[Route("kisu")]
		[HttpGet]
		public Task<ImageResult> Kisu() => DBFetchImagesAsync(ImageCategory.Kisu);

		[Route("warau")]
		[HttpGet]
		public Task<ImageResult> Warau() => DBFetchImagesAsync(ImageCategory.Warau);

		[Route("hisomu")]
		[HttpGet]
		public Task<ImageResult> Hisomu() => DBFetchImagesAsync(ImageCategory.Hisomu);

		[Route("unazuku")]
		[HttpGet]
		public Task<ImageResult> Unazuku() => DBFetchImagesAsync(ImageCategory.Unazuku);

		[Route("nomu")]
		[HttpGet]
		public Task<ImageResult> Nomu() => DBFetchImagesAsync(ImageCategory.Nomu);

		[Route("iie")]
		[HttpGet]
		public Task<ImageResult> Iie() => DBFetchImagesAsync(ImageCategory.Iie);

		[Route("nade")]
		[HttpGet]
		public Task<ImageResult> Nade() => DBFetchImagesAsync(ImageCategory.Nade);

		[Route("pekku")]
		[HttpGet]
		public Task<ImageResult> Pekku() => DBFetchImagesAsync(ImageCategory.Pekku);

		[Route("tsutsuku")]
		[HttpGet]
		public Task<ImageResult> Tsutsuku() => DBFetchImagesAsync(ImageCategory.Tsutsuku);

		[Route("pouto")]
		[HttpGet]
		public Task<ImageResult> Pouto() => DBFetchImagesAsync(ImageCategory.Pouto);

		[Route("naguru")]
		[HttpGet]
		public Task<ImageResult> Naguru() => DBFetchImagesAsync(ImageCategory.Naguru);

		[Route("hashiru")]
		[HttpGet]
		public Task<ImageResult> Hashiru() => DBFetchImagesAsync(ImageCategory.Hashiru);

		[Route("utsu")]
		[HttpGet]
		public Task<ImageResult> Utsu() => DBFetchImagesAsync(ImageCategory.Utsu);

		[Route("shagamu")]
		[HttpGet]
		public Task<ImageResult> Shagamu() => DBFetchImagesAsync(ImageCategory.Shagamu);

		[Route("tataku")]
		[HttpGet]
		public Task<ImageResult> Tataku() => DBFetchImagesAsync(ImageCategory.Tataku);

		[Route("neru")]
		[HttpGet]
		public Task<ImageResult> Neru() => DBFetchImagesAsync(ImageCategory.Neru);

		[Route("egao")]
		[HttpGet]
		public Task<ImageResult> Egao() => DBFetchImagesAsync(ImageCategory.Egao);

		[Route("doyao")]
		[HttpGet]
		public Task<ImageResult> Doyao() => DBFetchImagesAsync(ImageCategory.Doyao);

		[Route("mitsumeru")]
		[HttpGet]
		public Task<ImageResult> Mitsumeru() => DBFetchImagesAsync(ImageCategory.Mitsumeru);

		[Route("kangaeru")]
		[HttpGet]
		public Task<ImageResult> Kangaeru() => DBFetchImagesAsync(ImageCategory.Kangaeru);

		[Route("guu")]
		[HttpGet]
		public Task<ImageResult> Guu() => DBFetchImagesAsync(ImageCategory.Guu);

		[Route("kosoguru")]
		[HttpGet]
		public Task<ImageResult> Kosoguru() => DBFetchImagesAsync(ImageCategory.Kosoguru);

		[Route("tefuru")]
		[HttpGet]
		public Task<ImageResult> TeFuru() => DBFetchImagesAsync(ImageCategory.TeFuru);

		[Route("uinku")]
		[HttpGet]
		public Task<ImageResult> Uinku() => DBFetchImagesAsync(ImageCategory.Uinku);

		[Route("akubi")]
		[HttpGet]
		public Task<ImageResult> Akubi() => DBFetchImagesAsync(ImageCategory.Akubi);

		[Route("ikeru")]
		[HttpGet]
		public Task<ImageResult> Ikeru() => DBFetchImagesAsync(ImageCategory.Ikeru);
	}
}