namespace muhammedkayraozkaya_241103046.Models
{
    public class BookModel : BaseModel
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public int AuthorId { get; set; }

        public int StockCount { get; set; }

        public int Rating { get; set; }

        public BookGenre Genre { get; set; }
    }

    public enum BookGenre
    {
        Unknown,

        Novel,

        History,

        Philosophy,

        Biography,

        PD,

        Sociology,

        Politics
    }
}
