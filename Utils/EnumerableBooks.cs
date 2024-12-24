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
                return All.OrderByDescending(b => b.Rating);
            }
        }

        static public IEnumerable<BookModel> LestRating
        {
            get
            {
                return All.OrderBy(b => b.Rating);
            }
        }

        static public IEnumerable<BookModel> MostStocks
        {
            get
            {
                return All.OrderByDescending(b => b.Stocks);
            }
        }

        static public IEnumerable<BookModel> LestStocks
        {
            get
            {
                return All.OrderBy(b => b.Stocks);
            }
        }

        static public IEnumerable<BookModel> MostCost
        {
            get
            {
                return All.OrderByDescending(b => b.Cost);
            }
        }

        static public IEnumerable<BookModel> LestCost
        {
            get
            {
                return All.OrderBy(b => b.Cost);
            }
        }

        static public IEnumerable<BookModel> MostDiscount
        {
            get
            {
                return All.OrderByDescending(b => b.Discount);
            }
        }

        static public IEnumerable<BookModel> LestDiscount
        {
            get
            {
                return All.OrderBy(b => b.Discount);
            }
        }

        static public IEnumerable<BookModel> MostPrice
        {
            get
            {
                return All.OrderByDescending(b => b.Price());
            }
        }

        static public IEnumerable<BookModel> LestPrice
        {
            get
            {
                return All.OrderBy(b => b.Price());
            }
        }
    }
}
