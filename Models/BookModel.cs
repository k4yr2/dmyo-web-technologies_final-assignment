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
            return Math.Round(Cost - (Cost * (Discount / 100)), 2);
        }

        public string ImgStr() => $"{Id:D2}.jpg";
    }

    public class BookSection(string? title, IEnumerable<BookModel> source, int count)
    {
        public string? Title { get; } = title;

        public BookContainer Container { get; } = new(source, count);
    }

    public class BookContainer(IEnumerable<BookModel> source, int count)
    {
		public IEnumerable<BookModel> Source { get; } = source;

		public int Count { get; } = count;

		public IEnumerable<BookModel> Display => Count == 0 ? Source : Source.Take(Count);
	}
}