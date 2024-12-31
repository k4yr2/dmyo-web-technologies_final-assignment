using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using muhammedkayraozkaya_241103046.Datas;

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

        [HttpPost, Route("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = DataStore.users.Models().FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new (ClaimTypes.Name, user.Username),
                    new (ClaimTypes.Role, user.Role)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Login");
            }

            ViewBag.Error = "Geçersiz kullanıcı adı veya şifre";
            return View();
        }
    }
}
