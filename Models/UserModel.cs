﻿namespace muhammedkayraozkaya_241103046.Models
{
	public class UserModel(int id, string username, string password) : BaseModel(id)
	{
		public string Username { get; set; } = username;

		public string Password { get; set; } = password;
	}
}