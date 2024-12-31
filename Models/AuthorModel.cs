using muhammedkayraozkaya_241103046.Datas;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace muhammedkayraozkaya_241103046.Models
{
    public class AuthorModel(int id) : BaseModel(id)
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? DeathDate { get; set; }

        public IEnumerable<BookModel> Books { get; } = DataStore.books.Models().Where(b => b.AuthorId == id);

        public string? FullName()
        {
            var flag = FirstName == null;
            var flag2 = LastName == null;

            if (flag)
            {
                if (flag2)
                    return null;

                return LastName;
            }

            if (flag2)
                return FirstName;

            return $"{FirstName} {LastName}";
        }

        public int? GetAge()
        {
            if (BirthDate == null)
            {
                return null;
            }

            DateTime birth = BirthDate.Value;
            DateTime last = DeathDate == null
                ? DateTime.Today
                : DeathDate.Value;


            int age = last.Year - birth.Year;

            // Ay ve gün kontrolü
            if (birth.Date > last.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public string ImgStr()
        {
            return $"{Id:D2}.jpg";
        }
    }
}
