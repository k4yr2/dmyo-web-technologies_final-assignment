using Microsoft.AspNetCore.Mvc;
using muhammedkayraozkaya_241103046.Datas;
using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Controllers.Api
{
    [ApiController, Route("api/authors")]
    public class AuthorController : Controller
    {
        [HttpGet]
        public IActionResult Books()
        {
            return Ok(DataStore.authors.Models); // JSON olarak döndür
        }

        [HttpGet("{id}")]
        public IActionResult Book(int id)
        {
            if (DataStore.authors.Model(id, out AuthorModel? model))
                return Ok(model);

            return BadRequest();
        }
    }
}
