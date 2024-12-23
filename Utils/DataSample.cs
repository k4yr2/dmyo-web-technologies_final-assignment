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
            authors.Append(new(i++, new AuthorName() { First = "Fyodor", Last = "Dostoyevski", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "George", Last = "Orwell", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Antoine", Last = "de Saint-Exupéry", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "J.K.", Last = "Rowling", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Paulo", Last = "Coelho", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Victor", Last = "Hugo", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Mustafa Kemal", Last = "Atatürk", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "İlber", Last = "Ortaylı", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Osman", Last = "Turan", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Falih Rıfkı", Last = "Atay", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "İnalcık", Last = "Halil", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Sina", Last = "Akşin", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Engin", Last = "Geçtan", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Joseph", Last = "Murphy", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Daniel", Last = "Goleman", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Virginia", Last = "Woolf", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "David J.", Last = "Lieberman", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "David", Last = "Burns", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Erich", Last = "Fromm", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Şevket Süreyya", Last = "Aydemir", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Walter", Last = "Isaacson", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Hakan", Last = "Günday", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Ece", Last = "Temelkuran", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Albert", Last = "Einstein", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "James", Last = "Clear", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Napoleon", Last = "Hill", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Charles", Last = "Duhigg", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Mihaly", Last = "Csikszentmihalyi", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Stephen R.", Last = "Covey", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Jack", Last = "Canfield", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Tony", Last = "Robbins", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Anthony", Last = "Giddens", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "C. Wright", Last = "Mills", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Emile", Last = "Durkheim", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "John J.", Last = "Macionis", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Zygmunt", Last = "Bauman", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Ulrich", Last = "Beck", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Max", Last = "Weber", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Gabriel", Last = "Almond", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Juan J.", Last = "Linz", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Bertrand", Last = "Russell", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "Thomas", Last = "Hobbes", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
            authors.Append(new(i++, new AuthorName() { First = "William", Last = "Shirer", Nick = null }, new AuthorDate() { Birth = null, Death = null }));
        }

        /// <summary>
        /// Sample books for app
        /// </summary>
        static public void AppBooks(DataList<BookModel> books)
        {
            int i = 0;
            Random random = new();

            /* #1 Suç ve Ceza - Fyodor Dostoyevski*/
            books.Append(new(i++, 0, 0)
            {
                Title = "Suç ve Ceza",
                Description = "Fyodor Dostoyevski'nin insanın içsel çatışmaları ve ahlaki sorgulamalarını derinlemesine ele aldığı etkileyici bir roman.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #2 1984 - George Orwell*/
            books.Append(new(i++, 0, 1)
            {
                Title = "1984",
                Description = "George Orwell'in distopik dünyası, bireyin özgürlük mücadelesi ve totaliter rejimlerin karanlık yüzüyle doludur.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #3 Küçük Prens - Antoine de Saint-Exupéry*/
            books.Append(new(i++, 0, 2)
            {
                Title = "Küçük Prens",
                Description = "Antoine de Saint-Exupéry'nin, hayata dair derin ve anlamlı mesajlar içeren unutulmaz bir eseri.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #4 Harry Potter ve Felsefe Taşı - J.K. Rowling*/
            books.Append(new(i++, 0, 3)
            {
                Title = "Harry Potter ve Felsefe Taşı",
                Description = "J.K. Rowling'in büyü ve macera dolu dünyasına adım attıran, efsaneleşmiş serinin ilk kitabı.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #5 Simyacı - Paulo Coelho*/
            books.Append(new(i++, 0, 4)
            {
                Title = "Simyacı",
                Description = "Paulo Coelho'nun hayallerin peşinden gitme ve hayatın anlamını keşfetme üzerine unutulmaz bir romanı.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #6 Sefiller - Victor Hugo*/
            books.Append(new(i++, 0, 5)
            {
                Title = "Sefiller",
                Description = "Victor Hugo'nun, Fransız toplumunun farklı katmanlarını ve insan ruhunun derinliklerini ele aldığı başyapıtı.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #7 Hayvan Çiftliği - George Orwell*/
            books.Append(new(i++, 0, 1)
            {
                Title = "Hayvan Çiftliği",
                Description = "George Orwell'in siyasi eleştirilerle dolu, alegorik ve çarpıcı bir romanı.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #8 Nutuk - Mustafa Kemal Atatürk*/
            books.Append(new(i++, 1, 6)
            {
                Title = "Nutuk",
                Description = "Mustafa Kemal Atatürk'ün 1927 yılında Türkiye Cumhuriyeti'nin kuruluşuna dair önemli detayları aktardığı, eşsiz bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #9 Tarihimiz ve Kahramanlarımız - İlber Ortaylı*/
            books.Append(new(i++, 1, 7)
            {
                Title = "Tarihimiz ve Kahramanlarımız",
                Description = "İlber Ortaylı'nın, Türk tarihinin önemli olaylarını ve kahramanlarını anlattığı akıcı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #10 Selçuklu Tarihi - Osman Turan*/
            books.Append(new(i++, 1, 8)
            {
                Title = "Selçuklu Tarihi",
                Description = "Osman Turan'ın, Selçuklu İmparatorluğu'nun kuruluşu ve gelişimini detaylı bir şekilde ele aldığı eseri.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #11 Bir Devrin Perde Arkası - Falih Rıfkı Atay*/
            books.Append(new(i++, 1, 9)
            {
                Title = "Bir Devrin Perde Arkası",
                Description = "Falih Rıfkı Atay'ın, Cumhuriyet dönemi Türkiye'sinin perde arkasını gözler önüne serdiği etkileyici bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #12 Osmanlı İmparatorluğu’nun Kısa Tarihi - İnalcık Halil*/
            books.Append(new(i++, 1, 10)
            {
                Title = "Osmanlı İmparatorluğu’nun Kısa Tarihi",
                Description = "İnalcık Halil'in, Osmanlı tarihini kısa ve öz bir şekilde aktardığı temel bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #13 Türkiye’nin Yakın Tarihi - Sina Akşin*/
            books.Append(new(i++, 1, 11)
            {
                Title = "Türkiye’nin Yakın Tarihi",
                Description = "Sina Akşin'in, Türkiye'nin son yüzyıllık tarihine ışık tuttuğu kapsamlı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #14 Tarih Notları - İlber Ortaylı*/
            books.Append(new(i++, 1, 7)
            {
                Title = "Tarih Notları",
                Description = "İlber Ortaylı'nın, tarih üzerine derin analizler yaptığı öğretici bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #15 İnsan Olmak - Engin Geçtan*/
            books.Append(new(i++, 2, 12)
            {
                Title = "İnsan Olmak",
                Description = "Engin Geçtan'ın, insan psikolojisi ve kendini anlama üzerine derin analizler sunduğu bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #16 Bilinçaltının Gücü - Joseph Murphy*/
            books.Append(new(i++, 2, 13)
            {
                Title = "Bilinçaltının Gücü",
                Description = "Joseph Murphy'nin, bilinçaltı gücünü kullanarak hayatınızı nasıl değiştirebileceğinizi anlattığı etkileyici bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #17 Duygusal Zeka - Daniel Goleman*/
            books.Append(new(i++, 2, 14)
            {
                Title = "Duygusal Zeka",
                Description = "Daniel Goleman'ın, duygusal zekanın önemi ve hayatımızdaki etkilerini ele aldığı çığır açıcı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #18 Kendine Ait Bir Oda - Virginia Woolf*/
            books.Append(new(i++, 2, 15)
            {
                Title = "Kendine Ait Bir Oda",
                Description = "Virginia Woolf'un, kadınların toplumsal rollerini ve özgürlüklerini sorguladığı çarpıcı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #19 Sınırlarını Aşmak - David J. Lieberman*/
            books.Append(new(i++, 2, 16)
            {
                Title = "Sınırlarını Aşmak",
                Description = "David J. Lieberman'ın, kişisel sınırlarımızı aşarak daha iyi bir yaşam inşa etmenin yollarını anlattığı etkileyici bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #20 İyi Hissetmek - David Burns*/
            books.Append(new(i++, 2, 17)
            {
                Title = "İyi Hissetmek",
                Description = "David Burns'ün, duygusal sağlığı geliştirmek için bilimsel yöntemler sunduğu klasik bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #21 Sevme Sanatı - Erich Fromm*/
            books.Append(new(i++, 2, 18)
            {
                Title = "Sevme Sanatı",
                Description = "Erich Fromm'un, sevginin insan yaşamındaki yerini ve anlamını derinlemesine ele aldığı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #22 Atatürk - Şevket Süreyya Aydemir*/
            books.Append(new(i++, 3, 19)
            {
                Title = "Atatürk",
                Description = "Şevket Süreyya Aydemir'in, Mustafa Kemal Atatürk'ün hayatını detaylı bir şekilde anlattığı kapsamlı biyografi eseri.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #23 Steve Jobs - Walter Isaacson*/
            books.Append(new(i++, 3, 20)
            {
                Title = "Steve Jobs",
                Description = "Walter Isaacson'un, teknoloji dünyasının dahi lideri Steve Jobs'un hayatını konu alan büyüleyici bir biyografi.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #24 Einstein: Yaşamı ve Düşünceleri - Walter Isaacson*/
            books.Append(new(i++, 3, 20)
            {
                Title = "Einstein: Yaşamı ve Düşünceleri",
                Description = "Walter Isaacson'un, bilim dünyasının efsanesi Albert Einstein'ın yaşamını ve çalışmalarını anlattığı kapsamlı bir biyografi.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #25 Kendine Ait Bir Oda - Virginia Woolf*/
            books.Append(new(i++, 3, 15)
            {
                Title = "Kendine Ait Bir Oda",
                Description = "Virginia Woolf'un, kadınların toplumsal rollerini ve özgürlüklerini sorguladığı çarpıcı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #26 Yalnızım Çünkü Sen Varsın - Hakan Günday*/
            books.Append(new(i++, 3, 21)
            {
                Title = "Yalnızım Çünkü Sen Varsın",
                Description = "Hakan Günday'ın, yalnızlık ve insan ilişkileri üzerine derinlemesine düşüncelerini paylaştığı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #27 Büyük Usta: Nazım Hikmet - Ece Temelkuran*/
            books.Append(new(i++, 3, 22)
            {
                Title = "Büyük Usta: Nazım Hikmet",
                Description = "Ece Temelkuran'ın, Türk edebiyatının efsanevi şairi Nazım Hikmet'in yaşamını anlattığı etkileyici bir biyografi.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #28 Aydınlanma ve Sonsuzluk - Albert Einstein*/
            books.Append(new(i++, 3, 23)
            {
                Title = "Aydınlanma ve Sonsuzluk",
                Description = "Albert Einstein'ın, bilim ve felsefe üzerine görüşlerini aktardığı derinlemesine bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #29 Atomik Alışkanlıklar - James Clear*/
            books.Append(new(i++, 4, 24)
            {
                Title = "Atomik Alışkanlıklar",
                Description = "James Clear'ın, alışkanlıklarınızı nasıl dönüştürebileceğinizi anlatan pratik bir kişisel gelişim kitabı.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #30 Düşün ve Zengin Ol - Napoleon Hill*/
            books.Append(new(i++, 4, 25)
            {
                Title = "Düşün ve Zengin Ol",
                Description = "Napoleon Hill'in, başarıya ulaşmanın yollarını anlattığı klasik bir kişisel gelişim kitabı.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #31 Alışkanlıkların Gücü - Charles Duhigg*/
            books.Append(new(i++, 4, 26)
            {
                Title = "Alışkanlıkların Gücü",
                Description = "Charles Duhigg'in, alışkanlıkların yaşamımızdaki etkilerini ele aldığı çığır açıcı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #32 Akış: Mutluluk Bilimi - Mihaly Csikszentmihalyi*/
            books.Append(new(i++, 4, 27)
            {
                Title = "Akış: Mutluluk Bilimi",
                Description = "Mihaly Csikszentmihalyi'nin, mutlu bir yaşam için akış teorisini açıkladığı önemli bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #33 Etkili İnsanların 7 Alışkanlığı - Stephen R. Covey*/
            books.Append(new(i++, 4, 28)
            {
                Title = "Etkili İnsanların 7 Alışkanlığı",
                Description = "Stephen R. Covey'in, kişisel ve profesyonel başarı için 7 temel alışkanlığı açıkladığı klasik bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #34 Başarı İlkeleri - Jack Canfield*/
            books.Append(new(i++, 4, 29)
            {
                Title = "Başarı İlkeleri",
                Description = "Jack Canfield'ın, başarıya ulaşmak için temel prensipleri anlattığı ilham verici bir kişisel gelişim kitabı.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #35 Sınırsız Güç - Tony Robbins*/
            books.Append(new(i++, 4, 30)
            {
                Title = "Sınırsız Güç",
                Description = "Tony Robbins'in, kişisel güçlerinizi nasıl geliştirebileceğinizi anlattığı çığır açıcı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #36 Toplumların Yapısı - Anthony Giddens*/
            books.Append(new(i++, 5, 31)
            {
                Title = "Toplumların Yapısı",
                Description = "Anthony Giddens'ın, toplumların yapılarını ve işleyişini detaylı bir şekilde incelediği temel bir sosyoloji kitabı.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #37 Sosyolojik Düşünce - C. Wright Mills*/
            books.Append(new(i++, 5, 32)
            {
                Title = "Sosyolojik Düşünce",
                Description = "C. Wright Mills'in, sosyolojik düşünme becerisini geliştirmek için önemli ipuçları sunduğu bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #38 Sosyolojinin Temelleri - Emile Durkheim*/
            books.Append(new(i++, 5, 33)
            {
                Title = "Sosyolojinin Temelleri",
                Description = "Emile Durkheim'in, modern sosyolojinin temel taşlarını anlattığı etkileyici bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #39 Sosyolojiye Giriş - John J. Macionis*/
            books.Append(new(i++, 5, 34)
            {
                Title = "Sosyolojiye Giriş",
                Description = "John J. Macionis'in, sosyolojiye yeni başlayanlar için temel kavramları açıkladığı kapsamlı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #40 Sosyoloji ve İnsan Doğası - Zygmunt Bauman*/
            books.Append(new(i++, 5, 35)
            {
                Title = "Sosyoloji ve İnsan Doğası",
                Description = "Zygmunt Bauman'ın, sosyolojinin insan doğası üzerindeki etkilerini ele aldığı bir klasik.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #41 Toplumda Değişim - Ulrich Beck*/
            books.Append(new(i++, 5, 36)
            {
                Title = "Toplumda Değişim",
                Description = "Ulrich Beck'in, modern toplumların değişim süreçlerini irdelediği çarpıcı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #42 Kapitalizm ve Toplum - Max Weber*/
            books.Append(new(i++, 5, 37)
            {
                Title = "Kapitalizm ve Toplum",
                Description = "Max Weber'in, kapitalizm ve toplumsal yapılar üzerindeki etkilerini tartıştığı önemli bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #43 Siyaset Bilimine Giriş - Gabriel Almond*/
            books.Append(new(i++, 6, 38)
            {
                Title = "Siyaset Bilimine Giriş",
                Description = "Gabriel Almond'un, siyaset bilimine giriş niteliğindeki kapsamlı bir eseri.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #44 Demokrasi ve Otoriterizm - Juan J. Linz*/
            books.Append(new(i++, 6, 39)
            {
                Title = "Demokrasi ve Otoriterizm",
                Description = "Juan J. Linz'in, demokratik ve otoriter rejimlerin özelliklerini karşılaştırdığı derinlemesine bir çalışma.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #45 Siyasi Düşünceler Tarihi - Bertrand Russell*/
            books.Append(new(i++, 6, 40)
            {
                Title = "Siyasi Düşünceler Tarihi",
                Description = "Bertrand Russell'ın, siyasi düşünce tarihini ele aldığı kapsamlı bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #46 Çiftlikteki Devrim (Hayvan Çiftliği) - George Orwell*/
            books.Append(new(i++, 6, 1)
            {
                Title = "Çiftlikteki Devrim (Hayvan Çiftliği)",
                Description = "George Orwell'in alegorik başyapıtı, totaliter rejimlerin tehlikelerini ve güç yozlaşmasının etkilerini sarsıcı bir dille anlatıyor",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #47 Siyaset Üzerine - John Locke*/ 
            books.Append(new(i++, 6, 41)
            {
                Title = "Siyaset Üzerine",
                Description = "John Locke'un, modern siyasetin temel ilkelerini açıkladığı klasik eseri.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #48 Siyasi Felsefe - Thomas Hobbes*/
            books.Append(new(i++, 6, 42)
            {
                Title = "Siyasi Felsefe",
                Description = "Thomas Hobbes'un, siyasi teorileri ve toplum sözleşmesi üzerine düşüncelerini paylaştığı önemli bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });

            /* #49 Diktatörlüğün Yükselişi - William Shirer*/
            books.Append(new(i++, 6, 43)
            {
                Title = "Diktatörlüğün Yükselişi",
                Description = "William Shirer'in, diktatörlük rejimlerinin yükselişini ele aldığı tarihi bir eser.",
                Rating = 1 + random.NextDouble() * 4,
                StockCount = random.Next(0, 1001)
            });
        }
    }
}