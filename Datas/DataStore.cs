using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Datas
{
    static public class DataStore
    {
        static public readonly DataList<GenreModel> genres = new();

        static public readonly DataList<AuthorModel> authors = new();

        static public readonly DataList<BookModel> books = new();

        static DataStore()
        {
            int i;

            {   // Sample genres for app
                i = 0;
                genres.Append(new(i++) { Name = "Novel" });
                genres.Append(new(i++) { Name = "History" });
                genres.Append(new(i++) { Name = "Philosophy" });
                genres.Append(new(i++) { Name = "Biography" });
                genres.Append(new(i++) { Name = "Personal development" });
                genres.Append(new(i++) { Name = "Sociology" });
                genres.Append(new(i++) { Name = "Politics" });
            }

            {   // Sample authors for app
                i = 0;
                authors.Append(new(i++,
                    new AuthorName() { First = "Fyodor", Last = "Dostoyevski", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1821, 11, 11), Death = new DateTime(1881, 2, 9) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "George", Last = "Orwell", Nick = "Orwell" },
                    new AuthorDate() { Birth = new DateTime(1903, 6, 25), Death = new DateTime(1950, 1, 21) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Antoine", Last = "de Saint-Exupéry", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1900, 6, 29), Death = new DateTime(1944, 7, 31) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Joanne", Last = "Rowling", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1965, 7, 31), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Paulo", Last = "Coelho", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1947, 8, 24), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Victor", Last = "Hugo", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1802, 2, 26), Death = new DateTime(1885, 5, 22) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Mustafa Kemal", Last = "Atatürk", Nick = "Atatürk" },
                    new AuthorDate() { Birth = new DateTime(1881, 1, 1), Death = new DateTime(1938, 11, 10) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "İlber", Last = "Ortaylı", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1947, 5, 21), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Osman", Last = "Turan", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1914, 7, 5), Death = new DateTime(1978, 7, 11) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Falih Rıfkı", Last = "Atay", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1894, 1, 1), Death = new DateTime(1971, 9, 20) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Halil", Last = "İnalcık", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1916, 6, 7), Death = new DateTime(2016, 7, 25) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Sina", Last = "Akşin", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1942, 8, 3), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Engin", Last = "Geçtan", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1938, 12, 9), Death = new DateTime(2019, 7, 24) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Joseph", Last = "Murphy", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1898, 5, 20), Death = new DateTime(1981, 12, 16) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Daniel", Last = "Goleman", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1946, 3, 7), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Virginia", Last = "Woolf", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1882, 1, 25), Death = new DateTime(1941, 3, 28) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "David J.", Last = "Lieberman", Nick = null },
                    new AuthorDate() { Birth = null, Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "David", Last = "Burns", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1942, 1, 1), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Erich", Last = "Fromm", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1900, 3, 23), Death = new DateTime(1980, 3, 18) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Şevket Süreyya", Last = "Aydemir", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1906, 11, 6), Death = new DateTime(1996, 7, 4) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Walter", Last = "Isaacson", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1952, 5, 20), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Albert", Last = "Einstein", Nick = "Einstein" },
                    new AuthorDate() { Birth = new DateTime(1879, 3, 14), Death = new DateTime(1955, 4, 18) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Hakan", Last = "Günday", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1976, 5, 6), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Ece", Last = "Temelkuran", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1973, 7, 22), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "James", Last = "Clear", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1986, 1, 1), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Napoleon", Last = "Hill", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1883, 10, 26), Death = new DateTime(1970, 11, 8) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Charles", Last = "Duhigg", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1974, 1, 1), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Mihaly", Last = "Csikszentmihalyi", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1934, 9, 29), Death = new DateTime(2021, 10, 20) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Stephen R.", Last = "Covey", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1932, 10, 24), Death = new DateTime(2012, 7, 16) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Jack", Last = "Canfield", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1948, 8, 19), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Tony", Last = "Robbins", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1960, 2, 29), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Anthony", Last = "Giddens", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1938, 1, 8), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "C.", Last = "Wright Mills", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1916, 8, 28), Death = new DateTime(1962, 3, 20) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Emile", Last = "Durkheim", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1858, 4, 15), Death = new DateTime(1917, 11, 15) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "John J.", Last = "Macionis", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1948, 2, 7), Death = null }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Zygmunt", Last = "Bauman", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1925, 11, 19), Death = new DateTime(2017, 1, 9) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Ulrich", Last = "Beck", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1944, 5, 15), Death = new DateTime(2015, 1, 1) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Max", Last = "Weber", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1864, 4, 21), Death = new DateTime(1920, 6, 14) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Gabriel", Last = "Almond", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1911, 3, 12), Death = new DateTime(2002, 12, 25) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Juan J.", Last = "Linz", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1926, 5, 23), Death = new DateTime(2013, 10, 1) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Bertrand", Last = "Russell", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1872, 5, 18), Death = new DateTime(1970, 2, 2) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "John", Last = "Locke", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1632, 8, 29), Death = new DateTime(1704, 10, 28) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "Thomas", Last = "Hobbes", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1588, 4, 5), Death = new DateTime(1679, 12, 4) }));

                authors.Append(new(i++,
                    new AuthorName() { First = "William", Last = "Shirer", Nick = null },
                    new AuthorDate() { Birth = new DateTime(1904, 2, 23), Death = new DateTime(1993, 12, 28) }));
            }
        }
    }
}
