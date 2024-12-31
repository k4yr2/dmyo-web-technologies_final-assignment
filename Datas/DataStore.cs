using muhammedkayraozkaya_241103046.Models;
using muhammedkayraozkaya_241103046.Utils;

namespace muhammedkayraozkaya_241103046.Datas
{
    static public class DataStore
    {
		static public readonly DataList<UserModel> users = new();

		static public readonly DataList<GenreModel> genres = new();

        static public readonly DataList<AuthorModel> authors = new();

        static public readonly DataList<BookModel> books = new();

        static DataStore()
        {
            users.Append(new UserModel(0, "k4yr2", "12341"));

            DataSample.AppGenres(genres);
            DataSample.AppAuthors(authors);
            DataSample.AppBooks(books);

            authors.Shuffle();
            books.Shuffle();
        }
    }
}
