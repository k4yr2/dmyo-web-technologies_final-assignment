namespace muhammedkayraozkaya_241103046.Models
{
    public class AuthorModel : BaseModel
    {
        public AuthorName Name { get; } = new();

        public AuthorDate Date { get; } = new();
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
