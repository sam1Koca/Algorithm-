# Recursion
<br/>

- Bir problemin alt problemlere bölünüp hesaplanmasına, nerde son bulacağımı belirttiğimiz ifadelere recursion (Özyineleme) diyoruz. 

- Küçük bir tanımlama ile, Recursive fonksiyon içerisinde kendini çağıran fonksiyondur.

---

<br/>

## Recursive fonksiyon nasıl çalışır?

- Recursive fonksiyonlar iki kısımdan oluşur.<br/>

### 1 -> Base Case(Temel Durumlar/Şartlar)<br/>
- Base Case daima fonksiyonumuzun başlangıcında yazılan ve fonksiyonumuzun sınırlarını belirleyen kısımdır.
- Base Case kısmında fonksiyonumuz tekrardan çağırılmaz, sabit bir değer geri döndürür.
- Bu sayede fonksiyonumuzu sınırlandırmış oluruz.

<br/>

### 2 -> Recursive Case(Yinelenen Durum)<br/>
- Bu kısmı döngümüzün içerisinde çalışan kodlar olarak düşünebiliriz.
- Yani sürekli bir değeri geri döndüren ve fonksiyonumuzu tekrar tekrar çağıracak olan kısım burasıdır.

<br/>

Temel Yapısı Bu şekilde.🤓 <br/>

![C++_Recursion_Example1](https://user-images.githubusercontent.com/77436633/178626076-30bb2dde-4763-4ede-af11-db52fa8b0345.png)
<br/><br/>

🧵 Yukarıda 3 adet örnek yaptım -> Example-01 - Example-02 - Example-03
 - Kod yapıları üzerinde görerek, kendi editörünüzde deneyerek daha iyi anlayabileceğinizi ve kavraya bileceğinize inanıyorum.. :)
 
 <br/><br/>
 <b>🧐 Örnekleri inceledikten sonra, yüksek ihtimalle aklınıza şu soru gelecek; Ben Bunları Döngü kullanarak da yapabilirim..
  - Tamda burda işte Recursion Fonksiyonların bize sağladığı Avantaj ve Dezavantajlardan Bahsetmek gerkeiyor. Hadi Gelin hep birlikte Bakalım;</b><br/>
  ### Recursive Fonksiyon Avantajları
- Recursive fonksiyonlar ile çok daha az kod ile işlevi yüksek kodlar yazabilirsiniz.
- Kodunuz daha okunabilir olur.
<br/><br/>
### Recursive Fonksiyon Dezavantajları
- Bazı durumlarda çok yavaştır.
- Ufak bir hatada sonsuz döngüye girebilirsiniz.
- Recursive işlemler Stack’de tutulduğundan bellek sorunu ortaya çıkabilir
