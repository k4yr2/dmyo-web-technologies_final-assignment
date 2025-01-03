﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using muhammedkayraozkaya_241103046.Datas;

namespace muhammedkayraozkaya_241103046.Controllers
{
	[Route("account")]
	public class AccountController : Controller
	{
        [HttpGet, Route("")]
        public IActionResult Index()
        {
            if (!User.Identity?.IsAuthenticated ?? true)
            {
                return RedirectToAction("Login", "Account");
            }

            return View(DataStore.users.Models().FirstOrDefault(d => d.Username == User.Identity?.Name));
        }

        [HttpPost, Route("add-book")]
        public IActionResult AddBook(int id)
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                var user = DataStore.users.Models().FirstOrDefault(d => d.Username == User.Identity?.Name);
                if(user != null)
                {
                    user.AddBook(id);

                } 
            }

            return Content(""); 
        }


        [HttpGet, Route("login")]
		public IActionResult Login()
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Account");
            }

            return View();
		}

        [HttpPost, Route("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = DataStore.users.Models().FirstOrDefault(u => u.Username == username && u.Password == password);

            if (string.IsNullOrEmpty(username))
            {
				ViewBag.Error = "Username cannot be null or empty";
				return View();
			}

			if (string.IsNullOrEmpty(password))
			{
				ViewBag.Error = "Password cannot be null or empty";
				return View();
			}

			if (user == null)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }

            var claims = new List<Claim>
            {
                new (ClaimTypes.Name, user.Username),
                new (ClaimTypes.Role, user.Role)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "Account");
        }

        [HttpGet, Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet, Route("signup")]
        public IActionResult Signup()
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Account");
            }

            return View();
        }

		[HttpPost, Route("signup")]
		public async Task<IActionResult> Signup(string username, string password, string role)
		{
			var user = DataStore.users.Models().FirstOrDefault(u => u.Username == username);

			if (user != null)
			{
				ViewBag.Error = "Username already exists";
				return View();
			}

            DataStore.users.Append(user = new Models.UserModel(DataStore.users.Models().Count(), username, password, role));

			var claims = new List<Claim>
			{
				new (ClaimTypes.Name, user.Username),
				new (ClaimTypes.Role, user.Role)
			};

			var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

			return RedirectToAction("Index", "Account");
		}
	}
}
