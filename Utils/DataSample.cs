using muhammedkayraozkaya_241103046.Datas;
using muhammedkayraozkaya_241103046.Models;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace muhammedkayraozkaya_241103046.Utils
{
    static public class DataSample
    {
        /// <summary>
        /// Sample genres for app
        /// </summary>
        static public void AppGenres(DataList<GenreModel> genres)
        {
            genres.Append(new GenreModel(0)
            {
                Name = "Novel"
            });
            genres.Append(new GenreModel(1)
            {
                Name = "History"
            });
            genres.Append(new GenreModel(2)
            {
                Name = "Biography"
            });
        }

        /// <summary>
        /// Sample authors for app
        /// </summary>
        static public void AppAuthors(DataList<AuthorModel> authors)
        {
            authors.Append(new AuthorModel(0,
                new AuthorName() { First = "Fyodor", Last = "Dostoyevski", Nick = "Dostoyevski" },
                new AuthorDate() { Birth = new DateTime(1821, 11, 11), Death = new DateTime(1881, 2, 9) }));

            authors.Append(new AuthorModel(1,
                new AuthorName() { First = "George", Last = "Orwell", Nick = null },
                new AuthorDate() { Birth = new DateTime(1903, 6, 25), Death = new DateTime(1950, 1, 21) }));

            authors.Append(new AuthorModel(2,
                new AuthorName() { First = "Victor", Last = "Hugo", Nick = null },
                new AuthorDate() { Birth = new DateTime(1802, 2, 26), Death = new DateTime(1885, 5, 22) }));

            authors.Append(new AuthorModel(3,
                new AuthorName() { First = "Mustafa Kemal", Last = "Atatürk", Nick = "Atatürk" },
                new AuthorDate() { Birth = new DateTime(1881, 1, 1), Death = new DateTime(1938, 11, 10) }));

            authors.Append(new AuthorModel(4,
                new AuthorName() { First = "İlber", Last = "Ortaylı", Nick = null },
                new AuthorDate() { Birth = new DateTime(1947, 5, 21), Death = null }));

            authors.Append(new AuthorModel(5,
                new AuthorName() { First = "Halil", Last = "İnalcık", Nick = null },
                new AuthorDate() { Birth = new DateTime(1916, 9, 7), Death = new DateTime(2016, 7, 25) }));

            authors.Append(new AuthorModel(6,
                new AuthorName() { First = "Walter", Last = "Isaacson", Nick = null },
                new AuthorDate() { Birth = new DateTime(1952, 5, 20), Death = null }));

            authors.Append(new AuthorModel(7,
                new AuthorName() { First = "Şevket Süreyya", Last = "Aydemir", Nick = null },
                new AuthorDate() { Birth = new DateTime(1897, 1, 1), Death = new DateTime(1976, 3, 25) }));

            authors.Append(new AuthorModel(8,
                new AuthorName() { First = "Andrew", Last = "Morton", Nick = null },
                new AuthorDate() { Birth = new DateTime(1953, 1, 1), Death = null }));

        }

        /// <summary>
        /// Sample books for app
        /// </summary>
        static public void AppBooks(DataList<BookModel> books)
        {
            Random rng = new();
            double rating() => 1 + rng.NextDouble() * 4;
            int stocks() => rng.Next(1001);
            double cost() => rng.Next(1001);
            double discount() => rng.NextDouble() * 100;

            books.Append(new BookModel(0, 0, 0,
                new BookContent() { Title = "Suç ve Ceza", Description = "Fyodor Dostoyevski'nin başyapıtı \"Suç ve Ceza\", ahlaki ikilemler ve insan psikolojisinin derinliklerini keşfeder. Roman, fakir bir öğrenci olan Raskolnikov'un işlediği cinayet sonrası yaşadığı vicdan azabı ve içsel çatışmaları anlatır. Eser, suçun birey ve toplum üzerindeki etkilerini derinlemesine işler." },
                new BookDetails() { Rating = rating(), Stocks = stocks()},
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(1, 0, 0,
                new BookContent() { Title = "Karamazov Kardeşler", Description = "Dostoyevski'nin son romanı \"Karamazov Kardeşler\", bir ailenin trajik hikâyesi üzerinden insan doğasını, inanç ve ahlak kavramlarını sorgular. Baba Fyodor Pavloviç ve üç oğlu arasındaki ilişkiler, sevgi, nefret ve kıskançlık temaları etrafında şekillenir. Eser, felsefi derinliğiyle dikkat çeker." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(2, 0, 0,
                new BookContent() { Title = "Yeraltından Notlar", Description = "\"Yeraltından Notlar\", Dostoyevski'nin varoluşçu düşüncelere öncülük eden eserlerinden biridir. Toplumdan izole olmuş, isimsiz bir anlatıcının iç dünyasını ve toplumla olan çatışmasını anlatır. Bu karakter, modern insanın yabancılaşmasını ve içsel bunalımını temsil eder." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(3, 0, 1,
                new BookContent() { Title = "1984", Description = "George Orwell'in distopik romanı \"1984\", totaliter bir rejimin birey üzerindeki baskısını ve özgürlüklerin yok edilişini anlatır. Ana karakter Winston Smith, gerçeğin manipüle edildiği, düşünce suçunun cezalandırıldığı bir dünyada yaşar. Eser, otoriter yönetimlerin tehlikelerine dikkat çeker." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(4, 0, 1,
                new BookContent() { Title = "Hayvan Çiftliği", Description = "Orwell'in alegorik eseri \"Hayvan Çiftliği\", bir çiftlikteki hayvanların insanlara karşı isyanını ve sonrasında yaşananları anlatır. Başlangıçta eşitlik ve özgürlük vaatleriyle başlayan devrim, zamanla yeni bir diktatörlüğe dönüşür. Roman, siyasi yozlaşma ve iktidarın kötüye kullanılmasını eleştirir." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(5, 0, 2,
                new BookContent() { Title = "Sefiller", Description = "Victor Hugo'nun epik romanı \"Sefiller\", 19. yüzyıl Fransası'nda toplumsal adaletsizlikleri ve insan ruhunun direncini işler. Eski bir mahkûm olan Jean Valjean'ın kefaret arayışı, sevgi ve fedakârlık temaları etrafında şekillenir. Eser, toplumun en alt kesimlerinin yaşamını derinlemesine tasvir eder." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(6, 0, 2,
                new BookContent() { Title = "Notre Dame’ın Kamburu", Description = "Hugo'nun \"Notre Dame’ın Kamburu\" romanı, 15. yüzyıl Paris'inde geçer ve Notre Dame Katedrali'nin çan kulesinde yaşayan Quasimodo'nun trajik aşk hikâyesini anlatır. Güzel çingene kızı Esmeralda'ya duyduğu aşk, toplumun önyargıları ve adaletsizlikleriyle yüzleşmesine neden olur." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(7, 1, 3,
                new BookContent() { Title = "Nutuk", Description = "Mustafa Kemal Atatürk'ün \"Nutuk\" adlı eseri, Türkiye Cumhuriyeti'nin kuruluş sürecini ve Kurtuluş Savaşı'nı detaylı bir şekilde anlatır. 1919-1927 yılları arasındaki olayları kapsayan bu eser, Atatürk'ün liderlik vizyonunu ve Cumhuriyet'in temel ilkelerini ortaya koyar." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(8, 1, 3,
                new BookContent() { Title = "Zabit ve Kumandan ile Hasbihal", Description = "Atatürk'ün \"Zabit ve Kumandan ile Hasbihal\" eseri, subay ve komutanlara hitaben yazılmıştır. Askerî liderlik, disiplin ve sorumluluk konularında tavsiyeler içerir. Eser, Osmanlı İmparatorluğu'nun son dönemlerinde ordu mensuplarının moral ve motivasyonunu artırmayı amaçlar." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(9, 1, 4,
                new BookContent() { Title = "Yakın Tarihin Gerçekleri", Description = "İlber Ortaylı'nın \"Yakın Tarihin Gerçekleri\" kitabı, Osmanlı'dan Cumhuriyet'e geçiş sürecini ve Türkiye'nin modernleşme çabalarını analiz eder. Tarihî olayların arka planını ve dönemin önemli figürlerini objektif bir bakış açısıyla değerlendirir." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(10, 1, 4,
                new BookContent() { Title = "Cumhuriyet'in Doğuşu - Kurtuluş ve Kuruluş Yılları", Description = "Ortaylı'nın bu eseri, Türkiye Cumhuriyeti'nin kuruluş yıllarını ve Atatürk'ün reformlarını inceler. Kurtuluş Savaşı'nın stratejik adımları, Lozan Antlaşması ve Cumhuriyet'in ilanı gibi kritik dönemeçleri detaylandırır." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(11, 1, 4,
                new BookContent() { Title = "Osmanlı'yı Yeniden Keşfetmek", Description = "İlber Ortaylı'nın \"Osmanlı'yı Yeniden Keşfetmek\" kitabı, Osmanlı İmparatorluğu'nun yönetim yapısı, kültürü ve toplumsal hayatını derinlemesine inceler. Eser, Osmanlı mirasının modern Türkiye üzerindeki etkilerini de değerlendirir." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(12, 1, 5,
                new BookContent() { Title = "Kısa Osmanlı Tarihi", Description = "Halil İnalcık'ın \"Kısa Osmanlı Tarihi\" eseri, Osmanlı İmparatorluğu'nun kuruluşundan yıkılışına kadar olan süreci özetler. İmparatorluğun siyasi, ekonomik ve kültürel gelişmelerini kronolojik bir sırayla sunar." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(13, 1, 5,
                new BookContent() { Title = "Devlet-i Aliyye", Description = "İnalcık'ın \"Devlet-i Aliyye\" serisi, Osmanlı İmparatorluğu'nun tarihini derinlemesine analiz eder. Eser, imparatorluğun kuruluş, yükseliş ve duraklama dönemlerini detaylandırarak, Osmanlı yönetim sistemini ve toplum yapısını açıklar." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(14, 2, 6,
                new BookContent() { Title = "Steve Jobs", Description = "Walter Isaacson'ın biyografisi \"Steve Jobs\", Apple'ın kurucusu Steve Jobs'un hayatını ve teknoloji dünyasındaki devrim niteliğindeki katkılarını anlatır. Eser, Jobs'un yenilikçi vizyonu, liderlik tarzı ve kişisel hayatına dair derinlemesine bir bakış sunar." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(15, 2, 6,
                new BookContent() { Title = "Benjamin Franklin", Description = "Walter Isaacson'ın \"Benjamin Franklin\" adlı biyografisi, Amerika'nın kurucu babalarından biri olan Franklin'in çok yönlü hayatını inceler. Franklin'in bilimsel keşiflerinden politikadaki etkisine, yazılarından icatlarına kadar birçok yönü derinlemesine ele alır. Eser, Franklin'in zamanının ötesindeki vizyonunu ve etkisini vurgular." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(16, 2, 6,
                new BookContent() { Title = "Leonardo Da Vinci", Description = "\"Leonardo Da Vinci\", Walter Isaacson tarafından yazılmış, Rönesans'ın dahi sanatçısı ve bilim insanı Leonardo'nun hayatını ve eserlerini derinlemesine anlatır. Eser, Leonardo'nun yaratıcı zekasını, not defterlerinden icatlarına kadar detaylı bir şekilde inceler. Onun sanatı, bilimi ve hayata bakış açısı bu biyografide öne çıkar." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(17, 2, 7,
                new BookContent() { Title = "Tek Adam Cilt 1", Description = "Şevket Süreyya Aydemir'in \"Tek Adam\" serisinin ilk cildi, Mustafa Kemal Atatürk'ün çocukluk ve gençlik yıllarını anlatır. Balkan savaşlarından Çanakkale'ye, Kurtuluş Savaşı'na uzanan süreçte, liderlik vasıflarını ve devrimci kişiliğini tarihsel bir bağlamda ele alır." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(18, 2, 7,
                new BookContent() { Title = "İkinci Adam-Cilt 2", Description = "\"İkinci Adam\" serisinin ikinci cildi, İsmet İnönü'nün Cumhuriyet'in kuruluşundaki rolünü ve Atatürk'le olan ilişkisini ele alır. Aydemir, İnönü'nün liderlik anlayışını, diplomasi başarısını ve siyasi hayatını titizlikle işler. Bu eser, Cumhuriyet tarihine dair derin bir anlayış sunar." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(19, 2, 8,
                new BookContent() { Title = "Diana: Her True Story", Description = "Andrew Morton'ın yazdığı \"Diana: Her True Story\", Prenses Diana'nın yaşamını, saray hayatını ve mücadelelerini gözler önüne serer. Eser, Diana'nın samimi anlatıları ve yaşamına dair bilinmeyen detaylarla zenginleşmiştir. Kitap, Diana'nın halk tarafından neden bu kadar sevildiğini anlamaya yardımcı olur." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));

            books.Append(new BookModel(20, 2, 8 ,
                new BookContent() { Title = "Elizabeth and Margaret", Description = "Andrew Morton'ın \"Elizabeth and Margaret\" adlı kitabı, Kraliçe II. Elizabeth ve kız kardeşi Margaret'ın ilişkisini derinlemesine inceler. İki kardeşin çocukluk yıllarından yetişkinlik dönemine kadar, kraliyet ailesinin dinamiklerini ve kişisel çatışmalarını gözler önüne serer." },
                new BookDetails() { Rating = rating(), Stocks = stocks() },
                new BookPrice() { Cost = cost(), Discount = discount() }));
        }
    }
}