using Microsoft.AspNetCore.Mvc;
using muhammedkayraozkaya_241103046.Datas;
using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Controllers.Api
{
    [ApiController, Route("api/[controller]")]
    public class AuthorsController : Controller
    {
        [HttpGet]
        public IActionResult Authors()
        {
            return Ok(DataStore.authors.Models); // JSON olarak döndür
        }
    }
}
