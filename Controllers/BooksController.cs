using Microsoft.AspNetCore.Mvc;
using muhammedkayraozkaya_241103046.Datas;

namespace muhammedkayraozkaya_241103046.Controllers
{
    [Route("books")]
    public class BooksController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult Index()
        {
            return View(DataStore.books.Models());
        }

        [HttpGet, Route("details")]
        public IActionResult Details(int id)
        {
            return View(DataStore.books.Model(id)); 
        }
    }
}
