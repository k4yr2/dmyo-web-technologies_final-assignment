using Microsoft.AspNetCore.Mvc;

namespace muhammedkayraozkaya_241103046.Controllers
{
	[Route("account")]
	public class AccountController : Controller
	{
		[HttpGet, Route("login")]
		public IActionResult Login()
		{
			return View();
		}
	}
}
