namespace muhammedkayraozkaya_241103046.Models
{
    public class BookModel : BaseModel
    {
        public int AuthorId { get; set; }

        public BookCategory Category { get; set; }
    }

    public enum BookCategory
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
