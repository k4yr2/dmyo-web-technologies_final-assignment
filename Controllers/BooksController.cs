using Microsoft.AspNetCore.Mvc;
using muhammedkayraozkaya_241103046.Datas;

namespace muhammedkayraozkaya_241103046.Controllers
{
    [Route("books")]
    public class BooksController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult Index(int? genre, int? author)
        {
            var books = DataStore.books.Models();
            if (genre.HasValue)
            {
				books = books.Where(b => b.GenreId == genre.Value);
            }
			if (author.HasValue)
			{
				books = books.Where(b => b.AuthorId == author.Value);
			}

			return View(books);
        }

        [HttpGet, Route("details")]
        public IActionResult Details(int id)
        {
            return View(DataStore.books.Model(id)); 
        }
    }
}
