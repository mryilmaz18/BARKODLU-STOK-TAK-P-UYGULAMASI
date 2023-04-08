# Barkodlu-Stok-Takip-Otomasyonu
Yapmış olduğum uygulama barkod sistemli stok takip uygulaması olup aşağıdaki özellikleri barındırmaktadır.
## Öncelikle bizi Login Paneli karşılamaktadır;
- Kullanıcı kaydı yoksa kullanıcı kayıt ol seçeneğini seçerek kayıt yaptırabilir.
- Kayıt olma kısmında kişi bilgileri boş bırakmamalıdır ve TC Kimlik numarasının 11 karakterden oluşması gerekmektedir.
- Kullanıcı kayıt yaptıktan sonra Login Paneline tekrar yönlendirilerek doğru bilgileri girmesi halinde uygulamaya giriş yapması sağlanmaktadır aksi taktirde hatalı giriş ile karşılaşacaktır ve uygulamaya giriş yapamayacaktır.
## Giriş yapıldıktan sonra bizi Anasayfa karşılamaktadır.
- Anasayfamız müşteri ekleme, müşteri listeleme, ürün ekleme, ürün listeleme, satış listeleme, kategori ekleme, marka ekleme sayfalarına yönlendirme yapmaktadır. 
- Müşteri ekleme sayfasında boş kayıt ve daha önce oluşturulan kayıt gerçekleştirilemez.
- Müşteri listeleme sayfasında daha önce kaydedilen müşterilerin bilgileri güncellenebilir veya müşteri silinebilir. 
- Müşteri bulma konusunda müşteri özelliklerine göre filtreleme seçeneği mevcuttur.
- Ürün ekleme sayfasında kayıtlı ürün olmaması halinde ürün bilgileri doldurularak yeni ürün kaydı gerçekleşmektedir. 
- Boş bilgi girilmesi halinde ürün kaydı gerçekleşmemektedir.
- Var Olan Ürün kaydında ise ürün barkod numarası girilmesi halinde ürünün geri kalan bilgileri otomatik doldurularak sadece miktar girilmesi halinde var olan ürüne ekleme yapılmaktadır.
- Ürün listeleme sayfasında daha önce kaydedilen ürünlerin bilgileri güncellenebilir, ürün silinebilir veya ürünün marka kategori alanında değişiklikler yapılabilmektedir. 
- Ürün bulma konusunda ürün özelliklerine göre filtreleme seçeneği mevcuttur.
- Satışları listeleme kısmında daha önce yapılmış satışlar listelenmektedir. 
- İade işlemlerinde satır seçilip silinerek stok miktarına tekrar ekleme yapılabilmektedir.
- Kategori sayfasında kategori alanına ekleme yapılabilmektedir.
- Marka sayfasında ise kategori seçilerek ürün markasına ekleme yapılmaktadır.
## Anasayfamız üzerinden erişebileceğimiz özelliklerimiz ise;
#### Müşteri işlemleri kısmında; 
- Müşterinin TC numarasına çift tıklanması halinde Müşteri Listesi sayfasına yönlendirilir.
- Müşteri işlemleri kısmından müşterinin TC numarası girilmesi halinde diğer alanda otomatik doldurulmaktadır. 
- Müşteri işlemleri doldurulmadan satış yapma işlemi gerçekleşmemektedir.
#### Ürün işlemleri kısmında ise;
	- Satış ID’ si otomatik tanımlanmaktadır.
	- QR simgesine basıldığı zaman Barkod Okuma Sistemi devreye girecektir. 
	- Sisteme daha önceden tanımlanan ürünlerin barkod numaraları oluşturularak okutulabilir.
	- Barkod okuması gerçekleştikten sonra ürün bilgileri listelenmektedir. 
	- Ekle seçeneğine basıldığında tekrar Barkod Numarası okutulabilir.
	- Sepete aynı ürün eklenmesi halinde sepetteki ürünün miktarına ekleme yapılmaktadır.
	- Sepet tutarı sepetin alt kısmında “Genel Toplam” kısmında gözükmektedir.
	- Anasayfamızın sağ kısmında yer alan sil seçeneğinde ise satır seçilerek ürün silme işlemi gerçekleşmektedir.
	- Sil seçeneğinin altında yer alan Satış İptal seçeneğinde ise sepet tamamen boşaltılmaktadır.
	- Anasayfamızın sağ alt kısmında ise Satış Yap seçeneği mevcuttur. Satış yap seçeneğine tıklanması halinde satışımız Satış Listesi kısmına aktarılarak satış işlemimiz gerçekleşecektir.
