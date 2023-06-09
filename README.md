<h1 align="center">🌟 Electrical Appliances Store RESTful Web Api 🌟</h1>
<p>🟢Proje hakkında özet bilgi :</p>
<p>• Gelişmiş ve olgunlaşmış bir Web Api için içinde barındırdığı sayfalama, filtreleme, sıralama ve içerik pazarlığı olmak üzere Api güvenliği, 
 ön belleğe alma, hız sınırlandırma gibi pek çok yapıyı içinde barındıran ileri düzey bir Web Api geliştirdim.</p>
<p>• Web api için Asp.Net Core 6.0 Versionunu kullanarak Katmanlı mimari üzerinde projeyi oluşturup, geliştirdim.</p>
<p>• Projenin geniş kapsamlı anlatımını yalın ve güncel bir şekilde aşağıda yaparak görseller ile destekledim, hızlı bir şekilde inceleyebilirsiniz.</p>
<br>

![Resttasarım](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/34c452fc-bfc7-4fd3-b235-80c664ebd182)

<br>
<h1 align="center">🟠 Proje Görselleri ve Açıklamaları 🟠</h1>
<br>
<h2>🔶 1 - Entity Framework Core </h2>
<p>• Entity Framework Core .Net nesneleri kullanarak bir veri tabanıyla çalışmaya olanak tanıyan ve Microsoft tarfından geliştirilmiş bir ORM teknolojisi aracıdır.</p>
<p>• Genel olarak yazılması gereken veri erişim kodunun çoğuna olan ihtiyacı ortadan kaldırır ve otomatik üretir.</p>
<p>• Bu projede SQL veri tabanı için CodeFirst yaklaşımı ile EF Core'un sağlamış olduğu yapıları kullanarak veri tabanı işlemlerimi tamamlamış oldum.</p>
<br>
<h2>🔶 2 - Yazılım Mimarisi (Software Architecture) </h2>
<p>• N-tier Architecture mimarisi ile 'Entities', 'Presentation', 'Repositories', 'Services' katmanları ile uygulamanın yönetimini 
 ayrı, sade ve yalın bir şekilde yapılabilmesine imkan vermektedir.</p>
<p>• Katmanlı mimari ile her katmanın sorumluluğu ayrılmaktadır, bu şekilde proje büyüdükçe karmaşıklığın önüne geçilerek katmanların 
  daha temiz çalışması ve uygulama noktasında Api'ın niteliğini arttıracak şekilde geliştirilmesine imkan sağlamaktadır.</p>
<br>
<h2>🔶 3 - NLog Uygulaması (NLog Implementation) </h2>
<p>• NLog kütüphanesini mimariye dahil ederek loglama işlemlerini gerçekleştirdim.</p>
<p>• Kullanıcının atmış olduğu Requestlerin karşılığı olmadığında bunu bir txt uzantılı dosyaya loglamanın gerçekleştiği tarih ile beraber
  kaydederek istediğimiz zaman inceleyebilmek için loglarını alıyoruz.</p>
<br>

![1](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/a5664653-5f62-4422-9e20-ebc6f9e56807)

<br>
<h2>🔶 4 - Global Hata Yönetimi (Global Error Handling) </h2>
<p>• Hatalı istek(Request) atıldığında Global Hata yönetimi ile yazmış olduğumuz Custom Error Messages bize göstererek çözüme daha hızlı ulaşmamızı sağlamaktadır.</p>
<p>• Aşağıdaki resimde'de görüldügü gibi bu bize 0' id'li ürünü görmek istediğimizde bize hata mesajı veriyor.</p>
<br>

![2](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/44f2c953-725b-4f9a-8be9-d717465ea5d3)

<br>
<h2>🔶 5 - AutoMapper </h2>
<p>• İki nesneyi birbirine eşleyen karmaşık koddan kurtulmak için oluşturulan bir kütüphanedir.</p>
<p>• Oluşturduğumuz DTO(Data Transfer Object) üzerindeki dataları bir Destination'a Otomatik olarak Map'liyoruz yada kopyalıyoruz. 
  Bu işlemin terside söz konusu olabilir Destination'dan DTO'ya gidilebilir.</p>
<p>• Mapping Profile ile hangi nesne hangi nesneye Map'leneceğini belirliyoruz.</p>
<br>
<h2>🔶 6 - İçerik Pazarlığı (Content Negotiation) </h2>
<p>• Bir Api geliştirdikten sonra çok sayıda kullanıcımızında olduğunu varsayarsak bu Api ile farklı uygulamalarla konuşabiliriz 
  yada iletişim içinde olabiliriz yada doğrudan bizim Api'mizi tüketen istemcilerimiz olabilir, yani Clientlerimiz olabilir.</p>
<p>• Client'lar bize Request attığında eğerki bizim Apimiz içerik pazarlığına kapalıysa sadece tek tip Response dönüşü sağlayabilir.</p>
<p>• Bizim Api'miz içerik pazarlığına açık olduğu için bize gelen Requestlere 'text/csv', 'application/xml', 'application/json' vb. formatlarda Response sağlayabiliriz.</p>
<br>
<p>🟢 6.1 - text/xml </p>
<br>
  
![3xml](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/363de5ab-7028-482c-a796-542e5dfc8ab7)
  
<br>
<p>🟢 6.2 - application/json </p>
<br>
  
![4json](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/322917cf-05f0-49a4-827f-a9dec9b4a74f)
  
<br>
<p>🟢 6.3 - application/xml </p>
<br>
  
![5xml](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/5f55d406-9a85-4136-8e1d-04f65b3ecaf2)
  
<br>
<h2>🔶 7 - Doğrulama (Validation) </h2>
<p>• Veri manipulasyonu yaptığımız zaman tanımladığımız bir dizi kural setinin ilgili varlıklar üzerinde uygulanmasını sağlamaktadır.</p>
<p>• Client ile Server arasında data alışverişi gerçekleşeceği zaman bu veriler üzerinde tanımladığımız kuralların geçerli olup olmadığını kontrol etmemize olanak sağlar.</p>
<br>
<p>🟢 7.1 - Post Validation işlemi Price ve Title Validation Hatası </p>
<br>
  
![7_1validationpost](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/cc96e495-d809-4475-a985-ef75e4b25b3e)
  
<br>
<p>🟢 7.2 - Post Validation işlemi Price Validation Hatası </p>
<br>
  
![7_2validationpost](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/9b7f93d3-d99b-4c5c-915c-18e4a60957ee)
  
<br>
<p>🟢 7.3 - Post Validation işlemi Title Validation Hatası </p>
<br>
  
![7_3validationpost](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/d08469b2-5dbb-4463-81d4-1e7643bd74a2)
  
<br>
<p>🟢 7.4 - Put Validation işlemi Price ve Title Validation Hatası </p>
<br>
  
![7_4validationput](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/132f9539-4258-4843-9835-083b6bf6c5d3)
  
<br>
<p>🟢 7.5 - Put Validation işlemi Title Validation Hatası </p>
<br>
  
![7_5validationput](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/0e2bcd8c-3b3d-4112-97cb-5b085242950d)
  
<br>
<p>🟢 7.6 - Put Validation işlemi Price Validation Hatası </p>
<br>
  
![7_6validationput](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/d90435b4-9ee8-4cb0-bce1-0703941b4dee)
  
<br>
<h2>🔶 8 - Asenkron Kod (Asynchronous Code) </h2>
<p>• .Net yapısında 3 farklı asenkron programlama modeli vardır, bunlar ;</p>
<p>• Asynchronous Programming Model (APM)</p>
<p>• Event-based Asynchronous Pattern(EAP)</p>
<p>• Task-based Asynchronous Pattern(TAP)</p>
<p>• Projeyi Task-based Asynchronous Pattern(TAP) yani Görev tabanlı programlama modeli ile geliştirdim.</p>
<p>• Bizim Api'mize İstemcilerden Request geldiğinde bizim Thread Pool'umuz yani görev havuzumuzda sırasını 
  bekleyerek sırayla işleme alınır eğer havuz dolu ise istek(Request) bekletilir ve buna Senkron Programlama denir.</p>
<p>• Asenkron programlamada ise gelen Requestler beklemez ve başka bir Request işlemdeyken diğer Requestler'de işlemlerine 
  devam eder, bu durumda Asenkron(Async) Programlama performans açısından bize katkı sağlar.</p>
<p>• async, await ve Task Keywordleri ile tanımlanır.</p>
<br>

![13_1](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/e2a4809c-b9a0-4e2a-af41-34718146ac52)

<br>
<h2>🔶 9 - Eylem Filtreleri (Action Filters) </h2>
<p>• Action Filter bir Controller ya da  Controller içindeki 
  Action yapısına uygulanan ve bu yolla ilgili yapının düzenlenmesine olanak sağlayan bir attribute olarak ifade edilir. Action Filter'ler ;</p>
<p>• Authorization filters</p>
<p>• Resource filters</p>
<p>• Action filters</p>
<p>• Exception filters</p>
<p>• Result filters</p>
<p>• gibi yapılardan oluşmaktadır. Genel olarak yazılan Controller'ların başına yazılır.</p>
<br>
<h2>🔶 10 - Sayfalama (Pagination) </h2>
<p>• Sayfalama kısaca Api'den dönen Response'lerin kısmi olarak alınmasıdır. RESTful Api tasarımı için önemli bir özelliktir.</p>
<p>• İstediğimiz datalar çok büyük bir şekilde tutuluyor olabilir fakat bize sadece bazı datalar gerekli ise bu dataların hepsini 
  çağırmamız sunucu ve istemci açısından zaman olarak maaliyet oluşturcaktır, ama sayfalama yaparak veriyi parça parça halinde görüntüleyebilmekteyiz.</p>
<p>🟢 10.1 - Sayfalama işlemleri </p>
<br> 
  <p>• Resimdede görüdüğü gibi pageNumber vererek hangi sayfayı görmek istediğimizi belirtmiş oluyoruz.</p>
  <p>• pageSize özelliği ile bir sayfada kaç adat veri olacağını belirliyoruz.</p>
  <br>
  
![10_1](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/1998e3e1-07a2-488f-a09c-7c8229f4e058)
  
<br>
<p>🟢 10.2 - Sayfa Detay bilgisi </p>
<br>
  <p>• CurrentPage: Bulunduğumuz sayfa</p>
  <p>• TotalPage: Toplam sayfa sayısı</p>
  <p>• PageSize: Her sayfada listelenen veri sayısı</p>
  <p>• TotalCount: Toplam veri sayısı</p>
  <p>• HasPrevious: Bulunduğumuz sayfanın öncesinde bir sayfa varmı onun bilgisini verir varsa true yoksa false olarak gösterir.</p>
  <p>• HasPage: Bulunduğumuz sayfanın sonrasında bir sayfa varmı onun bilgisini verir varsa true yoksa false olarak gösterir.</p>
  <br>
  
![10_2pagedlist](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/b882ca61-b450-4a23-b898-9009adbb6af1)
  
<br>
<h2>🔶 11 - Filtreleme (Filtering) </h2>
<p>• Yalın olarak Filtreleme bir takım kriterlere bağlı olarak sonuçların getirilmesini sağlayan bir mekanizmadır.</p>
<p>• Query String yada Route ifadeleri ile gerçekleştirikmektedir.</p>
<p>• Aşağıdaki resimde'de görüldüğü üzere Api'nin price özelliğinde belli araklıktaki değere sahip dataları bize göstermektedir.</p>
<br>

![11filtering](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/d2b62f13-6c27-4d92-a525-a954edef1368)

<br>
<h2>🔶 12 - Arama (Searching) </h2>
<p>• Arama bir terim ya da anahtar değer yardımıyla uygulama içerisindeki en alakalı sonuçları döndürmek üzere uygulanan bir işlevdir.</p>
<p>• Arama işlemi duruma göre bir kaynak yada birden fazla kaynak üzerinde yapılabilir.</p>
<p>• Aranan kelime büyük küçük harf'e duyarsızdır, kelime ve datalar bu şekilde karşılaştırılır.</p>
<br>

![11search](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/ebac3308-2781-4c77-8ddd-383afc4b7d0b)

<br>
<h2>🔶 13 - Sıralama (Sorting) </h2>
<p>• Sorting query string parametreleri yardımıyla tercih edilen bir yolla sonuçların sıralanması işlevidir.</p>
<p>• OrderBy query string ile DESC yada ASC olarak sıralama yapılabilir.</p>
<br>
<p>🟢 13.1 - Büyükten küçüğe doğru(DESC) sıralama </p>
<br>
  
![12short](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/aebef200-bba4-42b0-ace2-48011ccb74b5)

<br>
<p>🟢 13.2 - Küçükten büyüğe doğru(ASC) sıralama </p>
<br>
  
![12short2](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/600c2c89-91bf-407f-b47b-1d92fcd6cdd2)

<br>
<h2>🔶 14 - Veri Şekillendirme (Data Shaping) </h2>
<p>• Data Shaping API tüketicisinin, sorgu dizesi aracılığıyla talep ettiği nesnenin alanlarını seçerek sonuç setini şekillendirmesini sağlar.</p>
<p>• API tasarımı ve ihtiyacına göre eklenebilir. </p>
<br>

![14_2](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/3136eb53-141b-418e-bd1b-4f42def65132)

<br>
<h2>🔶 15 - HATEOAS </h2>
<p>• Bir rest servisinin response üzerinden tüm içerik bilgilerini görebildiğimiz başka bir kaynağa ya da dökümana gerek kalmadan kullanabilmeye olanak sağlayan bir araçtır. Örnek verecek olursam bir kişinin kaydını getirmek için rest üzerinden gelen cevabın içerisinde o restin diğer yapabileceği tüm yeteneklerinde görülebileceği bir yapı sağlamaktadır. Projemizde başka Rest işlemleri eklediysek silme, güncelleme gibi işlemleri yapabilmek için hangi rest yolunun kullanılması gerektiği gibi bilgileri görüntüler.</p>
<p>• İyi geliştirilmiş bir API başlangıçta Hyper Media desteği sunmamış olsada sonradan kolaylıkla projeye dahil edilebilir.</p>
<p>• Hyper Media destegi vermek zorunlu değildir API'nin ihtiyacı var ise duruma göre proje'ye dahil edilmelidir.</p>
<br>

![15](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/380e9b23-b3d1-4712-a946-c52c54037319)

<br>
<h2>🔶 16 - Versiyonlama (Versioning) </h2>
<p>• API geliştirilirken gelişim sürecinde her ne kadar iş odaklı bir çalışma gerçekleştiriyor olsakta, öngörülemeyen yada sonradan ortaya çıkan ihtiyaçlar ile API' ımızı daha fazla sorumluluk eklememiz gerekebilmektedir. İşte böyle bir durumda yapılan değişikliklerde API'ların istemciler üzerindeki etkisini yönetebilmek ve operasyonel olarak gerçekleştirilen çalışmayı raporlayabilmek için her bir güncelleme neticesinde API’ları versiyonlamamız gerekmektedir.</p>
<br>
<p>🟢 16.1 - Controller Route ile v1 Versiyonlama </p>
<br>
  
![18v1](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/6a1933eb-19a2-448c-9c4b-aee3b4933d06)

<br>
<p>🟢 16.2 - Controller Route ile v2 Versiyonlama </p>
<br>
  
![18v2](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/495af3e7-859d-43e5-ad19-98429b3b7abe)

<br>
<p>🟢 16.3 - Header ile 1.0 Versiyonlama </p>
<br>
  
![18v1_header](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/e14e7173-ac64-4581-9cd5-4965464c7dc2)

<br>
<p>🟢 16.4 - Header ile 2.0 Versiyonlama </p>
<br>
  
![18v2_header](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/e9299e5c-71ce-4e66-86c8-f11e96bd1e49)

<br>
<h2>🔶 17 - Önbelleğe Alma (Caching) </h2>
<p>• Bir Api'nin hem kalitesini ve hemde performansını artırmak ihtiyacı duyuyorsak temel nitekiklerden biride Api'nin veriyi ön belleğe alma mekanizmasını işleterek bu niteliğe sahip olmasıdır.</p>
<p>• Caching, özet olarak gerekli isteklerin ayırt edilebilmesidir.</p>
<p>• REST mimarisi üzerinde Client ile Server arasındaki Requestlerde Cache mekanizması ile ilk kez gönderdiği 
 Request'ten sonra veri Cache'de tutulmaya başlanır, aynı Request tekrar atıldığında Server ile iletişime geçilmeden eğer belirlediğimiz belli süreyi(Cache-control: max-age:) aşmadıysa Cache mekanizmasından Response edilir. Bu durum Server'ımızın trafiğini azaltmamızda performans olarak çok büyük katkı sağlamaktadır. </p>
<br>
<p>• Cache-Control ile  refresh süresini görebiliyoruz.</p>
<p>• ETag ile cache için Header'da tutulan referans adını görebiliyoruz. </p>
<p>• Last-Modified : oluşturulduğu tarih.</p>
<p>• Expires : sonlanacağı tarih tarih.</p>
<br>
  
![19](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/95f2c5c8-4a38-4c5e-bec5-2b1de4f44e10)

<br>
<h2>🔶 18 - Hız Sınırlama ve Kısıtlama (Rate Limit and Throttling) </h2>
<p>• Client'dan gelen Requestleri dakikalık olarak belli bir sınırda tutmamızı sağlamaktadır. İstemci'nin isteklerini sınırlayıp serverin trafiğini kontrol altına alarak performans maaliyeti açısından bize çok fayda sağlamaktadır.</p>
<br>
<p>• Aşağıdaki resimde de görüldüğü gibi ;</p>
<p>• X-Rate-Limit-Limit : 1m / istemciye vermiş olduğumuz 1 dk boyunca toplam istek süresidir. </p>
<p>• X-Rate-Limit-Remaining : İstemciye 1 dk içinde verdiğimiz istek adedi'dir. Bu sayı 1 dk içinde 10 adettir ve Geliştiricinin isteğine göre değiştirilebilir. Süresi dolunca tekrardan yenilenir.</p>
<p>• X-Rate-Limit-Reset : Burada da istemci istek hakkını doldurmamış olsa dahi bu süre dolunca otomatik olarak resetlenir ve tekrardan 10 adet istek yani Request atabilir.</p>
<br>
  
![20](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/fbe5463a-168f-4c30-83bf-b83c39097442)

<br>
<p>• Aşağıdaki resimde de görüldüğü gibi ;</p>
<p>• Burada Request(istek) sınırını dolduran client'a hata mesajı veriyoruz ve bize sunucumuz Status Code: '429 Too Many Requests' cevabı ile dönüş yapıyor.</p>
<br>
  
![20 hata](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/c5dfc553-7c9e-4931-826e-df91afeea3f6)

<br>
<h2>🔶 19 - JWT, Identity ve Refresh Token </h2>
<p>• Oturum açma ve yetkilendirme işlemleri için Identity çerçevesini kullanarak bu yapıyı tasarlamış olduk.</p>
<p>• Role bazlı oturum açma işlemleri için 3 rol belirkedik ve bunlar; </p>
<p>• Admin, User ve Editör olarak tanımladık. aralarındaki fark ise şöyleki Admin kullanıcısı istediği her yere istek atabiliyorken, User ve Editör kullanıcısı için sadece gerekli yerlere istek atabilmektedirler. </p>
<br>
<p>🟢 19.1 - Register işlemi </p>
<p>• Aşağıdaki resimde görüldüğü gibi yeni kullanıcı kayıt işlemi yapıyoruz ve en alttada rolünü belirliyoruz.</p>
<p>• Bize Status Code: 201 Created ile dönüş yapıyor, kayıt işlemi başarılı.</p>
<br>
  
![21_yenikayit](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/65f2bd9e-10ef-482d-98e5-1ab6180329d1)

<br>
<p>🟢 19.2 - Giriş işlemi </p>
<p>• Aşağıdaki resimde görüldüğü gibi daha önceden oluşturmus oldugum admin kullanıcısı ile sisteme giriş yapıyoruz.</p>
<p>• Bize Status Code: 200 OK ile dönüş yapıyor, giriş işlemi başarılı.</p>
<br>
  
![21_giriş](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/b1c4a212-4b24-42b1-9669-6e9d1564039c)

<br>
<p>🟢 19.3 - Kullanıcı girişi yapılmadan Request işlemi </p>
<p>• Aşağıdaki resimde görüldüğü gibi sistemde hiç aktif olmadan direk request atancı bize sonuçları döndürmüyor.</p>
<p>• Bize Status Code: 401 Unauthorized ile dönüş yapıyor, giriş işlemi başarısız oluyor ve istek cevap alamıyor.</p>
<br>
  
![21girisyapmalısınhatası](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/c223f76d-0120-450b-b1b0-8314d704926d)

<br>
<p>🟢 19.4 - Yetkisiz kullanıcının Request işlemi </p>
<p>• Aşağıdaki resimde görüldüğü gibi yetkisi olmayan kullanıcı 1'nolu ürünün güncelleme işlemini yapmak için istek gönderiyor.</p>
<p>• Bize Status Code: 403 Forbidden ile dönüş yapıyor, yetkisiz işlem başarısız oluyor ve istek cevap alamıyor.</p>
<br>
  
![21_kullanıcıhata](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/911784d9-2f21-4677-9122-c627d2173750)

<br>
<p>🟢 19.5 - Refresh Token işlemi </p>
<p>• Aşağıdaki resimde görüldüğü gibi daha önceden Login olan kullanıcımızın Token süresi dolunca yeniden bizim access token ve refresh token'imizi göndererek süresi yeniliyoruz.</p>
<p>• Bize Status Code: 200 OK ile dönüş yapıyor, refresh token yenileniyor ve veritabanına ekleniyor.</p>
<br>
  
![21refresh](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/14dd67a4-0412-4b1c-9d43-6894aeb65e7d)

<br>
<h2>🔶 20 - Veritabanı Diagramı </h2>
<p>• Veritabanındaki bütün tabloların, kolonların ve tablo ilişkilerinin yapısı aşağıdaki resimde gösterilmiştir.</p>
<br>

![databaseddiagrams](https://github.com/akoselioren/Electrical-Appliances-Store-RESTful-Api/assets/112801816/b92c5ed7-7f41-46b1-93b9-42ff96f60745)

<br>
<h1 align="center">🟠 Yararlanılan Kaynaklar 🟠</h1>
<br>
<h3>[ 1 ] • https://www.btkakademi.gov.tr/portal/course/asp-net-core-web-api-23993</h3>
<h3>[ 2 ] • https://github.com/zcomert/BTK-Akademi-ASPNET-Core-Web-Api</h3>
<h3>[ 3 ] • https://dotnet.microsoft.com/en-us/apps/aspnet/apis</h3>
<h3>[ 4 ] • https://learn.microsoft.com/en-us/azure/architecture/best-practices/api-design</h3>
<h3>[ 5 ] • https://learn.microsoft.com/tr-tr/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio</h3>
<br>
<h1 align="center">🟠 Projenin Kurulumu 🟠</h1>
<br>
<p>• Github'dan projeyi indirip, Visual Studio'da açtıkdan sonra WebApi Katmanında bulunan appsettings.json dosyasına girerek SQL 
  veritabanı yolunu kendi veritabanı yolunuz ile güncelleyin.</p>
<p>• Sonrasında bağlantı yolu doğru ise Package Manager Console'dan Migration işlemlerini yaparak veri tabanını oluşturabilirsiniz.</p>
<p>• Veri tabanınız oluştuğunda içinde 3'er adet örnek veri ile beraber oluşmaktadır. Siz bu verileri değiştirebilir yada üzerine ekleyebilirsiniz.</p>
<br>
<h2 align="center">🌟Proje'yi Yıldızlayıp(⭐) bana destekte bulunabilirsiniz..🌟</h5>
