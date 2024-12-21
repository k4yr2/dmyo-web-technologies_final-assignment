namespace muhammedkayraozkaya_241103046.Models
{
    public class BookModel : BaseModel
    {
        public int AuthorId { get; set; }

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
