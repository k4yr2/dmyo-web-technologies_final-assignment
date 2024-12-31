using muhammedkayraozkaya_241103046.Datas;
using System.Xml.Linq;

namespace muhammedkayraozkaya_241103046.Models
{
	public class UserModel(int id, string username, string password, string role) : BaseModel(id)
	{
		public string Username { get; set; } = username;

		public string Password { get; set; } = password;

        public string Role { get; set; } = role;

		public int[] BookIDs { get; set; } = [];

		public BookModel?[] Books
		{
			get
			{
				return BookIDs.Select(DataStore.books.Model).ToArray();
            }
		}

		public void AddBook(int id)
		{
			if (BookIDs.Contains(id))
			{
				return;
			}

			int[] newArray = new int[BookIDs.Length + 1];
			Array.Copy(BookIDs, newArray, BookIDs.Length);
			newArray[BookIDs.Length] = id;
			BookIDs = newArray; 
		}
    }
}