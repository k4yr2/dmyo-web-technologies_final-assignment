using muhammedkayraozkaya_241103046.Datas;
using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Utils
{
    static public class EnumerableBooks
    {
        static public IEnumerable<BookModel> All
        {
            get
            {
                return DataStore.books.Models;
            }
        }

        static public IEnumerable<BookModel> MostRating
        {
            get
            {
                return All.OrderByDescending(b => b.Details.Rating);
            }
        }

        static public IEnumerable<BookModel> LestRating
        {
            get
            {
                return All.OrderBy(b => b.Details.Rating);
            }
        }
    }
}
