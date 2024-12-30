using Microsoft.AspNetCore.Mvc;
using muhammedkayraozkaya_241103046.Datas;

namespace muhammedkayraozkaya_241103046.Controllers
{
	[Route("authors")]
	public class AuthorsController : Controller
	{
		[HttpGet, Route("")]
		public IActionResult Index()
		{
			return View(DataStore.authors.Models());
		}

		[HttpGet, Route("details")]
		public IActionResult Details(int id)
		{
			return View(/*DataStore.authors.Model(id)*/);
		}
	}
}
