namespace muhammedkayraozkaya_241103046.Models
{
    public class BookModel(int id, int genre, int author, BookContent? content = null, BookDetails? details = null, BookPrice? price = null) : BaseModel(id)
    {
        public int GenreId { get; } = genre;

        public int AuthorId { get; } = author;

        public BookContent Content { get; } = content ?? new();

        public BookDetails Details { get; } = details ?? new();

        public BookPrice Price { get; } = price ?? new();

        public string ImgStr() => $"{Id:D2}.jpg";
    }

    public class BookContent
    {
        public string? Title { get; set; }

        public string? Description { get; set; }
    }

    public class BookDetails
    {
        public int Stocks { get; set; }

        public double Rating { get; set; }
    }

    public class BookPrice
    {
        public double Cost { get; set; }

        public double Discount { get; set; }

        public double Discounted()
        {
            return Cost - (Cost * (Discount/100));
        }
    }
}
