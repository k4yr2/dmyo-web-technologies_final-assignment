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

        static public IEnumerable<BookModel> MostStocks
        {
            get
            {
                return All.OrderByDescending(b => b.Details.Stocks);
            }
        }

        static public IEnumerable<BookModel> LestStocks
        {
            get
            {
                return All.OrderBy(b => b.Details.Stocks);
            }
        }

        static public IEnumerable<BookModel> MostCost
        {
            get
            {
                return All.OrderByDescending(b => b.Price.Cost);
            }
        }

        static public IEnumerable<BookModel> LestCost
        {
            get
            {
                return All.OrderBy(b => b.Price.Cost);
            }
        }

        static public IEnumerable<BookModel> MostDiscount
        {
            get
            {
                return All.OrderByDescending(b => b.Price.Discount);
            }
        }

        static public IEnumerable<BookModel> LestDiscount
        {
            get
            {
                return All.OrderBy(b => b.Price.Discount);
            }
        }

        static public IEnumerable<BookModel> MostDiscounted
        {
            get
            {
                return All.OrderByDescending(b => b.Price.Discounted());
            }
        }

        static public IEnumerable<BookModel> LestDiscounted
        {
            get
            {
                return All.OrderBy(b => b.Price.Discounted());
            }
        }
    }
}
