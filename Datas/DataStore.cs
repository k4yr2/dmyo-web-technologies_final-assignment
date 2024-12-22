using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Datas
{
    static public class DataStore
    {
        static public readonly DataList<GenreModel> genres = new();

        static public readonly DataList<AuthorModel> authors = new();

        static public readonly DataList<BookModel> books = new();
    }
}
