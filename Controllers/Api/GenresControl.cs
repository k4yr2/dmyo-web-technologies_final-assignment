using Microsoft.AspNetCore.Mvc;
using muhammedkayraozkaya_241103046.Datas;
using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Controllers.Api
{
    [ApiController, Route("api/[controller]")]
    public class GenresController : Controller
    {
        [HttpGet]
        public IActionResult GetAllGenres()
        {
            return Ok(DataStore.genres.Models); // JSON olarak döndür
        }
    }
}
