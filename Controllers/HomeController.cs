using Microsoft.AspNetCore.Mvc;

namespace muhammedkayraozkaya_241103046.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet, Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
