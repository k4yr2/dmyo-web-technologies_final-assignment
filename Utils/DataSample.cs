using muhammedkayraozkaya_241103046.Datas;
using muhammedkayraozkaya_241103046.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace muhammedkayraozkaya_241103046.Utils
{
    static public class DataSample
    {
        /// <summary>
        /// Sample genres for app
        /// </summary>
        static public void AppGenres(DataList<GenreModel> genres)
        {   // Sample genres for app
            int i = 0;
            genres.Append(new(i++) { Name = "Novel" });
            genres.Append(new(i++) { Name = "History" });
            genres.Append(new(i++) { Name = "Philosophy" });
            genres.Append(new(i++) { Name = "Biography" });
            genres.Append(new(i++) { Name = "Personal development" });
            genres.Append(new(i++) { Name = "Sociology" });
            genres.Append(new(i++) { Name = "Politics" });
        }

        /// <summary>
        /// Sample authors for app
        /// </summary>
        static public void AppAuthors(DataList<AuthorModel> authors)
        {
            int i = 0;
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
                new AuthorDate() { Birth = new DateTime(1881, 5, 19), Death = new DateTime(1938, 11, 10) }));

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

        /// <summary>
        /// Sample books for app
        /// </summary>
        static public void AppBooks(DataList<BookModel> books)
        {
            int i = 0;
            Random random = new();
  
            // **Roman** (GenreId: 0)
            books.Append(new(i++, 0, 0) { Title = "Suç ve Ceza", Description = "Fyodor Dostoyevski'nin başyapıtlarından biri, insanın içsel çatışmalarını ele alır.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 0, 1) { Title = "1984", Description = "George Orwell'in distopik romanı, totaliter rejimin tehlikelerini vurgular.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 0, 2) { Title = "Küçük Prens", Description = "Antoine de Saint-Exupéry'nin ünlü masalı, yaşam ve insanlık üzerine derin anlamlar taşır.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 0, 3) { Title = "Harry Potter ve Felsefe Taşı", Description = "J.K. Rowling'in fantastik serisinin ilk kitabı, genç bir büyücünün hikayesini anlatır.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 0, 4) { Title = "Simyacı", Description = "Paulo Coelho'nun, kişisel efsaneyi bulmak için bir yolculuğa çıkan bir gencin hikayesini anlatan romanı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 0, 5) { Title = "Sefiller", Description = "Victor Hugo'nun Fransız devrimi dönemindeki toplumsal eşitsizlikleri ele alan eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 0, 6) { Title = "Hayvan Çiftliği", Description = "George Orwell'in, hayvanlar tarafından yönetilen bir çiftlikteki diktatörlük ve devrim sürecini ele aldığı romanı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });

            // **Tarih** (GenreId: 1)
            books.Append(new(i++, 1, 7) { Title = "Nutuk", Description = "Mustafa Kemal Atatürk'ün Türkiye Cumhuriyeti'nin kurulduğu dönemdeki konuşmalarını içeren eser.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 1, 8) { Title = "Tarihimiz ve Kahramanlarımız", Description = "İlber Ortaylı'nın Türk tarihi üzerine kaleme aldığı önemli eserlerinden biri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 1, 9) { Title = "Selçuklu Tarihi", Description = "Osman Turan'ın, Selçuklu Devleti'nin tarihine dair kapsamlı bir bakış sunduğu eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 1, 10) { Title = "Bir Devrin Perde Arkası", Description = "Falih Rıfkı Atay'ın, Türk Kurtuluş Savaşı'nın perde arkasına dair yazdığı önemli eser.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 1, 11) { Title = "Osmanlı İmparatorluğu’nun Kısa Tarihi", Description = "İnalcık Halil'in, Osmanlı İmparatorluğu'nun kuruluşundan çöküşüne kadar geçirdiği süreçleri incelediği önemli eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 1, 12) { Title = "Türkiye’nin Yakın Tarihi", Description = "Sina Akşin'in, yakın dönemdeki Türk tarihi üzerine yazdığı derinlemesine eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 1, 13) { Title = "Tarih Notları", Description = "İlber Ortaylı'nın, tarihsel olaylara dair görüş ve değerlendirmelerini içeren eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });

            // **Felsefe** (GenreId: 2)
            books.Append(new(i++, 2, 14) { Title = "İnsan Olmak", Description = "Engin Geçtan'ın, insan psikolojisi üzerine yazdığı temel eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 2, 15) { Title = "Bilinçaltının Gücü", Description = "Joseph Murphy'nin, bilinçaltının gücünü ve potansiyelini keşfetmeye yönelik önemli eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 2, 16) { Title = "Duygusal Zeka", Description = "Daniel Goleman'ın, duygusal zekanın birey ve toplum üzerindeki etkilerini incelediği eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 2, 17) { Title = "Kendine Ait Bir Oda", Description = "Virginia Woolf'un, kadınların özgürlüklerini kazanabilmesi için gereken alanı tartıştığı önemli eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 2, 18) { Title = "Sınırlarını Aşmak", Description = "David J. Lieberman'ın, kişisel engelleri aşmaya yönelik stratejiler sunduğu eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 2, 19) { Title = "İyi Hissetmek", Description = "David Burns'in, depresyon ve kaygı ile başa çıkmaya yönelik psikolojik rehber kitabı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 2, 20) { Title = "Sevme Sanatı", Description = "Erich Fromm'un, sevgi ve insan ilişkilerini anlamaya yönelik felsefi bir bakış sunduğu eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });

            // **Biyografi** (GenreId: 3)
            books.Append(new(i++, 3, 21) { Title = "Atatürk", Description = "Şevket Süreyya Aydemir'in, Mustafa Kemal Atatürk'ün hayatını ve mücadelesini anlattığı biyografi.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 3, 22) { Title = "Steve Jobs", Description = "Walter Isaacson'un, Apple kurucusu Steve Jobs'un hayatını ve başarılarını konu alan biyografisi.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 3, 23) { Title = "Einstein: Yaşamı ve Düşünceleri", Description = "Walter Isaacson'un, ünlü bilim insanı Albert Einstein'ın hayatı ve bilimsel katkılarını anlatan biyografi.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 3, 24) { Title = "Kendine Ait Bir Oda", Description = "Virginia Woolf'un, kadınların özgürlüklerini kazanabilmesi için gereken alanı tartıştığı biyografisi.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 3, 25) { Title = "Yalnızım Çünkü Sen Varsın", Description = "Hakan Günday'ın, bireysel yalnızlık üzerine yazdığı ve insanın içsel yolculuğunu anlatan bir biyografi.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 3, 26) { Title = "Anne Frank: Günlük", Description = "Anne Frank'in, Nazi işgali altındaki Amsterdam'da yazdığı ünlü günlüğü.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 3, 27) { Title = "Socrates: Aydınlanma", Description = "Plato'nun, eski Yunan filozoflarından Sokrat'ın hayatına dair yazdığı eser.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });

            // **Kişisel Gelişim** (GenreId: 4)
            books.Append(new(i++, 4, 23) { Title = "Atomik Alışkanlıklar", Description = "James Clear'ın, küçük alışkanlıkların büyük değişimlere nasıl yol açtığını anlattığı kişisel gelişim kitabı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 4, 24) { Title = "Düşün ve Zengin Ol", Description = "Napoleon Hill'in, başarı ve zenginlik üzerine yazdığı klasik kişisel gelişim kitabı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 4, 25) { Title = "Alışkanlıkların Gücü", Description = "Charles Duhigg'in, alışkanlıkların insanlar üzerindeki güçlü etkisini keşfettiği kişisel gelişim kitabı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 4, 26) { Title = "Akış: Mutluluk Bilimi", Description = "Mihaly Csikszentmihalyi'nin, akış durumu ve mutluluk üzerine yazdığı çalışması.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 4, 27) { Title = "Etkili İnsanların 7 Alışkanlığı", Description = "Stephen R. Covey'in, başarılı ve etkili insanların uyguladığı alışkanlıklar üzerine yazdığı popüler kişisel gelişim kitabı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 4, 28) { Title = "Başarı İlkeleri", Description = "Jack Canfield'in, başarıya ulaşmak için izlenmesi gereken temel ilkeleri ele aldığı kişisel gelişim kitabı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 4, 29) { Title = "Sınırsız Güç", Description = "Tony Robbins'in, insanların kendi potansiyellerini keşfetmesi için yazdığı kişisel gelişim kitabı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });

            // **Sosyoloji** (GenreId: 5)
            books.Append(new(i++, 5, 32) { Title = "Sosyolojiye Giriş", Description = "Anthony Giddens'ın, sosyolojinin temel kavramlarını ve sosyal yapıları incelediği eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 5, 33) { Title = "Toplum ve İnsanın Doğası", Description = "Emile Durkheim'in, toplumsal yapılar ve birey arasındaki ilişkiyi ele aldığı eser.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 5, 34) { Title = "Sosyal Psikoloji", Description = "David Myers'ın, bireylerin toplum içindeki davranışlarını ve sosyal etkileşimleri incelediği kitabı.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 5, 35) { Title = "Sosyal Sınıflar", Description = "Max Weber'in, toplumsal sınıf yapılarının etkilerini incelediği önemli sosyolojik çalışması.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 5, 36) { Title = "Sosyolojik Düşünme", Description = "Harold D. Lasswell'in, sosyolojik düşünme tarzını tanımlayan ve toplumu analiz etme yöntemlerini ele alan eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 5, 37) { Title = "Toplumun Anatomisi", Description = "Emile Durkheim'in toplumsal yapıları analiz etmek için kullandığı teorileri ele aldığı önemli bir eser.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 5, 38) { Title = "Modern Toplum ve Değişim", Description = "Anthony Giddens'in, modern toplumu ve toplumsal değişimleri ele aldığı sosyolojik çalışması.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });

            // **Politika** (GenreId: 6)
            books.Append(new(i++, 6, 39) { Title = "Siyaset Bilimine Giriş", Description = "John J. Mearsheimer'in, siyaset biliminin temel ilkelerini ve uluslararası ilişkiler teorilerini açıklayan eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 6, 40) { Title = "Demokrasi ve Totalitarizm", Description = "Karl Popper'ın, demokrasi ve totaliter rejimler arasındaki farkları ve her birinin toplumsal etkilerini incelediği çalışması.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 6, 41) { Title = "Toplum ve Devlet", Description = "Jean-Jacques Rousseau'nun, devletin doğasını ve toplumun birey üzerindeki etkilerini tartıştığı eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 6, 42) { Title = "Hegemonya ve İktidar", Description = "Antonio Gramsci'nin, hegemonyanın toplumdaki rolü ve iktidar ilişkilerini ele alan önemli eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 6, 43) { Title = "Çatışma ve Toplum", Description = "Ralf Dahrendorf'un, toplum içindeki sınıf çatışmalarını ve bunların toplumsal düzen üzerindeki etkilerini incelediği eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 6, 44) { Title = "Politik Ekonomi", Description = "Karl Marx'ın, ekonomi ve politika arasındaki ilişkiyi açıklamak için geliştirdiği teorileri içeren eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
            books.Append(new(i++, 6, 45) { Title = "Uluslararası İlişkiler", Description = "Kenneth Waltz'un, uluslararası ilişkiler teorileri üzerine yazdığı önemli eseri.", Rating = random.Next(5, 11), StockCount = random.Next(0, 1001) });
        }
    }
}