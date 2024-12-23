using Microsoft.AspNetCore.Mvc;
using muhammedkayraozkaya_241103046.Datas;
using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Controllers.Api
{
    [ApiController, Route("api/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(DataStore.books.Models); // JSON olarak döndür
        }
    }
}
