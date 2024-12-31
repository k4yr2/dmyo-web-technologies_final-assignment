using muhammedkayraozkaya_241103046.Datas;

namespace muhammedkayraozkaya_241103046.Models
{
	public class UserModel(int id, string username, string password, string role) : BaseModel(id)
	{
		public string Username { get; set; } = username;

		public string Password { get; set; } = password;

        public string Role { get; set; } = role;

		public int[] BookIDs { get; set; } = Array.Empty<int>();

		public BookModel?[] Books
		{
			get
			{
				return BookIDs.Select(DataStore.books.Model).ToArray();
            }
		}
    }
}