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

            books.Append(new(i++, 0, 0)
            { // Novel - Fyodor Dostoyevski
                Title = "Fyodor Dostoyevski",
                Description = "Fyodor Dostoyevski'nin başyapıtı olan Suç ve Ceza, bir insanın suçlu olma, vicdan azabı çekme, suçun karşısındaki adalet arayışını anlatan bir romandır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 0, 1)
            { // Novel - George Orwell
                Title = "George Orwell",
                Description = "George Orwell'in distopik eseri 1984, totaliter bir rejimde bireyin özgürlüğü üzerine yazılmış bir uyarıdır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 0, 2)
            { // Novel - Antoine de Saint-Exupéry
                Title = "Antoine de Saint-Exupéry",
                Description = "Antoine de Saint-Exupéry'nin modern bir masalı olan Küçük Prens, insanları anlamak ve yaşamı sorgulamak üzerine derin bir öğreti sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 0, 3)
            { // Novel - J.K. Rowling
                Title = "J.K. Rowling",
                Description = "J.K. Rowling'in ünlü serisinin ilk kitabı, Harry Potter'ın sihirli dünyasına ilk adımını attığı hikayeyi anlatır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 0, 4)
            { // Novel - Paulo Coelho
                Title = "Paulo Coelho",
                Description = "Paulo Coelho'nun Simyacı adlı eseri, kendi kişisel efsanesini takip etmek ve hayallerinin peşinden gitmek üzerine bir yolculuğu anlatır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 0, 5)
            { // Novel - Victor Hugo
                Title = "Victor Hugo",
                Description = "Victor Hugo'nun Sefiller adlı eseri, Fransız devrimi sonrası toplumsal eşitsizliği ve insan haklarını sorgulayan bir başyapıttır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 0, 1)
            { // Novel - George Orwell
                Title = "George Orwell",
                Description = "George Orwell'in yazdığı Hayvan Çiftliği, totaliter yönetimlerin ve diktatörlüğün eleştirisini yapan bir alegorik eserdir.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 1, 6)
            { // History - Mustafa Kemal Atatürk
                Title = "Mustafa Kemal Atatürk",
                Description = "Mustafa Kemal Atatürk tarafından yazılan Nutuk, Türk Kurtuluş Savaşı ve Cumhuriyetin kuruluşuna dair tarihi bir belgedir.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 1, 7)
            { // History - İlber Ortaylı
                Title = "İlber Ortaylı",
                Description = "İlber Ortaylı'nın Türk tarihi üzerine yazdığı bu eser, Türk milletinin kahramanlık tarihine ışık tutar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 1, 8)
            { // History - Osman Turan
                Title = "Osman Turan",
                Description = "Osman Turan'ın Selçuklu İmparatorluğu hakkında yazdığı eserde, Selçuklu Devleti'nin tarihi detaylı bir şekilde ele alınır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 1, 9)
            { // History - Falih Rıfkı Atay
                Title = "Falih Rıfkı Atay",
                Description = "Falih Rıfkı Atay'ın kaleme aldığı bu eser, Türk milletinin bağımsızlık mücadelesinin perde arkasını anlatan bir belgedir.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 1, 10)
            { // History - İnalcık Halil
                Title = "İnalcık Halil",
                Description = "İnalcık Halil'in Osmanlı İmparatorluğu hakkında yazdığı bu eser, Osmanlı'nın kuruluşundan sona ermesine kadar olan süreci kapsamaktadır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 1, 11)
            { // History - Sina Akşin
                Title = "Sina Akşin",
                Description = "Sina Akşin'in yazdığı Türkiye’nin Yakın Tarihi, Cumhuriyetin ilk yıllarından günümüze kadar olan gelişmeleri anlatır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 1, 7)
            { // History - İlber Ortaylı
                Title = "İlber Ortaylı",
                Description = "İlber Ortaylı'nın Tarih Notları, tarihsel olaylara dair kişisel yorumlarını ve analitik bakış açısını sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 2, 12)
            { // Philosophy - Engin Geçtan
                Title = "Engin Geçtan",
                Description = "Engin Geçtan'ın İnsan Olmak adlı eseri, insan psikolojisini derinlemesine inceleyerek insanın varoluşsal sorgulamalarına ışık tutar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 2, 13)
            { // Philosophy - Joseph Murphy
                Title = "Joseph Murphy",
                Description = "Joseph Murphy'nin Bilinçaltının Gücü adlı eseri, insanın bilinçaltını kullanarak yaşamını nasıl değiştirebileceğini anlatır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 2, 14)
            { // Philosophy - Daniel Goleman
                Title = "Daniel Goleman",
                Description = "Daniel Goleman'ın Duygusal Zeka adlı kitabı, insanların duygusal zekalarını geliştirmeleri ve bu zekayı günlük yaşamlarına nasıl entegre edebilecekleri üzerine bilgiler sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 2, 15)
            { // Philosophy - Virginia Woolf
                Title = "Virginia Woolf",
                Description = "Virginia Woolf'un Kendine Ait Bir Oda adlı eseri, kadınların yaratıcı olabilmesi için özgürlüğe ve kendi odalarına sahip olmalarının gerekliliğini vurgular.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 2, 16)
            { // Philosophy - David J. Lieberman
                Title = "David J. Lieberman",
                Description = "David J. Lieberman'ın Sınırlarını Aşmak adlı kitabı, insanın kendi potansiyelini keşfetmesi ve sınırlarını aşabilmesi için pratik öneriler sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 2, 17)
            { // Philosophy - David Burns
                Title = "David Burns",
                Description = "David Burns'in İyi Hissetmek adlı kitabı, depresyonla mücadele eden kişilere yardımcı olabilecek pratik teknikler ve stratejiler sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 2, 18)
            { // Philosophy - Erich Fromm
                Title = "Erich Fromm",
                Description = "Erich Fromm'un Sevme Sanatı adlı eseri, sevginin insan doğası üzerindeki derin etkilerini ve sağlıklı bir sevginin nasıl olabileceğini inceler.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 3, 19)
            { // Biography - Şevket Süreyya Aydemir
                Title = "Şevket Süreyya Aydemir",
                Description = "Şevket Süreyya Aydemir'in Atatürk adlı eseri, Türkiye Cumhuriyeti'nin kurucusu Mustafa Kemal Atatürk'ün hayatını ve düşüncelerini detaylı bir şekilde ele alır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 3, 20)
            { // Biography - Walter Isaacson
                Title = "Walter Isaacson",
                Description = "Walter Isaacson'ın Steve Jobs biyografisi, Apple'ın kurucusu Steve Jobs'un hayatını, iş hayatını ve vizyonunu ele alır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 3, 21)
            { // Biography - Walter Isaacson
                Title = "Walter Isaacson",
                Description = "Walter Isaacson'ın Einstein: Yaşamı ve Düşünceleri adlı eseri, Albert Einstein'ın yaşamına dair kapsamlı bir biyografi sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 3, 15)
            { // Biography - Virginia Woolf
                Title = "Virginia Woolf",
                Description = "Virginia Woolf'un Kendine Ait Bir Oda adlı eseri, kadınların yaratıcı olabilmesi için özgürlüğe ve kendi odalarına sahip olmalarının gerekliliğini vurgular.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 3, 22)
            { // Biography - Hakan Günday
                Title = "Hakan Günday",
                Description = "Hakan Günday'ın Yalnızım Çünkü Sen Varsın adlı eseri, modern insanın yalnızlıkla ve kendi iç dünyasıyla mücadelesini anlatır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 3, 23)
            { // Biography - Ece Temelkuran
                Title = "Ece Temelkuran",
                Description = "Ece Temelkuran'ın Büyük Usta: Nazım Hikmet adlı eseri, Türk edebiyatının en önemli şairlerinden Nazım Hikmet'in yaşamına ve edebiyatına dair bir biyografi sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 3, 24)
            { // Biography - Albert Einstein
                Title = "Albert Einstein",
                Description = "Albert Einstein'in Aydınlanma ve Sonsuzluk adlı eseri, bilimsel düşünceye dair kişisel görüşlerini ve felsefi bakış açılarını sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 4, 25)
            { // Personal development - James Clear
                Title = "James Clear",
                Description = "James Clear'in Atomik Alışkanlıklar adlı eseri, kişisel gelişim için küçük alışkanlıkların gücünü anlatır ve hedeflere ulaşmanın pratik yollarını sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 4, 26)
            { // Personal development - Napoleon Hill
                Title = "Napoleon Hill",
                Description = "Napoleon Hill'in Düşün ve Zengin Ol adlı eseri, kişisel başarıya ulaşmak için gereken zihinsel tutumları ve stratejileri detaylandırır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 4, 27)
            { // Personal development - Charles Duhigg
                Title = "Charles Duhigg",
                Description = "Charles Duhigg'in Alışkanlıkların Gücü adlı kitabı, alışkanlıkların bilimsel temellerini ve bunların kişisel gelişim üzerindeki etkilerini inceler.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 4, 28)
            { // Personal development - Mihaly Csikszentmihalyi
                Title = "Mihaly Csikszentmihalyi",
                Description = "Mihaly Csikszentmihalyi'nin Akış: Mutluluk Bilimi adlı eseri, insanın tam anlamıyla kendini kaybettiği anları ve bunların mutluluk üzerindeki etkilerini keşfeder.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 4, 29)
            { // Personal development - Stephen R. Covey
                Title = "Stephen R. Covey",
                Description = "Stephen R. Covey'in Etkili İnsanların 7 Alışkanlığı adlı eseri, kişisel gelişim ve liderlik üzerine önemli stratejiler sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 4, 30)
            { // Personal development - Jack Canfield
                Title = "Jack Canfield",
                Description = "Jack Canfield'in Başarı İlkeleri adlı eseri, kişisel başarıya ulaşmak için izlenmesi gereken yol haritasını sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 4, 31)
            { // Personal development - Tony Robbins
                Title = "Tony Robbins",
                Description = "Tony Robbins'in Sınırsız Güç adlı eseri, kişisel gücün nasıl keşfedileceğini ve hayatın her alanında nasıl daha başarılı olunabileceğini anlatır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 5, 32)
            { // Sociology - Anthony Giddens
                Title = "Anthony Giddens",
                Description = "Anthony Giddens'in Toplumların Yapısı adlı eseri, toplumsal yapıların nasıl şekillendiğini ve bireylerin toplum içerisindeki rolünü tartışır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 5, 33)
            { // Sociology - C. Wright Mills
                Title = "C. Wright Mills",
                Description = "C. Wright Mills'in Sosyolojik Düşünce adlı eseri, sosyolojik düşüncenin temel ilkelerini ve toplumsal olayları ele alma yöntemlerini inceler.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 5, 34)
            { // Sociology - Emile Durkheim
                Title = "Emile Durkheim",
                Description = "Emile Durkheim'in Sosyolojinin Temelleri adlı eseri, sosyoloji biliminin kurucularından birinin bakış açısını yansıtarak, toplumsal yapıları ve kurumları inceler.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 5, 35)
            { // Sociology - John J. Macionis
                Title = "John J. Macionis",
                Description = "John J. Macionis'in Sosyolojiye Giriş adlı eseri, sosyolojinin temel kavramlarını ve kuramlarını anlamaya yönelik bir rehber sunar.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 5, 36)
            { // Sociology - Zygmunt Bauman
                Title = "Zygmunt Bauman",
                Description = "Zygmunt Bauman'ın Sosyoloji ve İnsan Doğası adlı eseri, modern toplumlardaki hızlı değişimlerin bireyler üzerindeki etkilerini inceler.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 5, 37)
            { // Sociology - Ulrich Beck
                Title = "Ulrich Beck",
                Description = "Ulrich Beck'in Toplumda Değişim adlı eseri, modern toplumların karşı karşıya kaldığı tehlikeler ve bu tehlikelerin toplumsal yapılar üzerindeki etkilerini inceler.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 5, 38)
            { // Sociology - Max Weber
                Title = "Max Weber",
                Description = "Max Weber'in Kapitalizm ve Toplum adlı eseri, kapitalizmin toplumsal yapı üzerindeki etkilerini ve toplumsal davranışları nasıl şekillendirdiğini tartışır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 6, 39)
            { // Politics - Gabriel Almond
                Title = "Gabriel Almond",
                Description = "Gabriel Almond'un Siyaset Bilimine Giriş adlı eseri, siyaset biliminin temel kavramlarını ve teorilerini ele alır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 6, 40)
            { // Politics - Juan J. Linz
                Title = "Juan J. Linz",
                Description = "Juan J. Linz'in Demokrasi ve Otoriterizm adlı eseri, demokrasi ile otoriterizm arasındaki farkları ve bu iki yönetim biçiminin toplumsal etkilerini tartışır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 6, 41)
            { // Politics - Bertrand Russell
                Title = "Bertrand Russell",
                Description = "Bertrand Russell'in Siyasi Düşünceler Tarihi adlı eseri, siyaset felsefesinin tarihsel gelişimini ve önemli düşünürleri ele alır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 6, 13)
            { // Politics - George Orwell
                Title = "George Orwell",
                Description = "George Orwell'in Çiftlikteki Devrim (Hayvan Çiftliği) adlı eseri, totaliter yönetimlerin eleştirisi ve toplumun köleleşmesini anlatan bir alegoridir.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 6, 42)
            { // Politics - John Locke
                Title = "John Locke",
                Description = "John Locke'un Siyaset Üzerine adlı eseri, hükümetin meşruiyetinin ve bireysel özgürlüklerin temellerini tartışır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 6, 43)
            { // Politics - Thomas Hobbes
                Title = "Thomas Hobbes",
                Description = "Thomas Hobbes'un Siyasi Felsefe adlı eseri, devletin ve toplumsal sözleşmenin doğasını ele alır.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });

            books.Append(new(i++, 6, 44)
            { // Politics - William Shirer
                Title = "William Shirer",
                Description = "William Shirer'in Diktatörlüğün Yükselişi adlı eseri, Nazi Almanyası'ndaki diktatörlük yönetimini ve bunun toplumsal etkilerini inceler.",
                Rating = random.Next(5, 11),
                StockCount = random.Next(0, 1001)
            });
        }
    }
}