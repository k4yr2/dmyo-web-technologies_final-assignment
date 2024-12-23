﻿using Microsoft.AspNetCore.Mvc;
using muhammedkayraozkaya_241103046.Datas;
using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Controllers.Api
{
    [ApiController, Route("api/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet]
        public IActionResult Books()
        {
            return Ok(DataStore.books.Models); // JSON olarak döndür
        }

        [HttpGet("{id}")]
        public IActionResult Book(int id)
        {
            if (DataStore.books.Model(id, out BookModel? model))
                return Ok(model);

            return BadRequest();
        }
    }
}
