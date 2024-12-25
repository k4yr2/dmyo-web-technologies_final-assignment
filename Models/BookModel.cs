using muhammedkayraozkaya_241103046.Datas;

namespace muhammedkayraozkaya_241103046.Models
{
    public class BookModel(int id, int genre, int author) : BaseModel(id)
    {
        public int GenreId { get; } = genre;

        public GenreModel? Genre { get; } = DataStore.genres.Model(genre);

        public int AuthorId { get; } = author;

        public AuthorModel? Author { get; } = DataStore.authors.Model(author);

        public string? Title { get; set; }

        public string? Description { get; set; }

        public int Stocks { get; set; }

        public double Rating { get; set; }

        public double Cost { get; set; }

        public double Discount { get; set; }

        public double Price()
        {
            return Cost - (Cost * (Discount / 100));
        }

        public string ImgStr() => $"{Id:D2}.jpg";
    }
}