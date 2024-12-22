using static System.Runtime.InteropServices.JavaScript.JSType;

namespace muhammedkayraozkaya_241103046.Models
{
    public class AuthorModel(int id, AuthorName name, AuthorDate date) : BaseModel(id)
    {
        public AuthorName Name { get; } = name;

        public AuthorDate Date { get; } = date;

        public int? GetAge()
        {
            if (Date.Birth == null)
            {
                return null;
            }

            DateTime birth = Date.Birth.Value;
            DateTime last = Date.Death == null
                ? DateTime.Today
                : Date.Death.Value;


            int age = last.Year - birth.Year;

            // Ay ve gün kontrolü
            if (birth.Date > last.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }

    public class AuthorName
    {
        public string? First { get; set; }

        public string? Last { get; set; }

        public string? GetFull()
        {
            var flag = First == null;
            var flag2 = Last == null;

            if (flag)
            {
                if (flag2)
                    return null;

                return Last;
            }

            if (flag2)
                return First;

            return $"{First} {Last}";
        }
    }

    public class AuthorDate
    {
        public DateTime? Birth { get; set; }

        public DateTime? Death { get; set; }
    }
}
