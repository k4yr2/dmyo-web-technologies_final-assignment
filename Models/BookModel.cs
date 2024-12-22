﻿namespace muhammedkayraozkaya_241103046.Models
{
    public class BookModel(int id, int genre, int author) : BaseModel(id)
    {
        public int GenreId { get; } = genre;

        public int AuthorId { get; } = author;

        public string? Title { get; set; }

        public string? Description { get; set; }

        public int StockCount { get; set; }

        public int Rating { get; set; }
    }
}
