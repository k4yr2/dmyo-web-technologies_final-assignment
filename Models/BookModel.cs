namespace muhammedkayraozkaya_241103046.Models
{
    public class BookModel(int id) : BaseModel(id)
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public int GenreId { get; set; }

        public int AuthorId { get; set; }

        public int StockCount { get; set; }

        public int Rating { get; set; }
    }
}
