# UdemyCalismaNotlar_MuratYucedag


Burda birçok olan kodlar benim c# alanında yeniden kendimden emin işler yapmadan önceki tekrar için bulundurdugum bir repodur.

foreach(1234) 
1 degişken türü 
2 degişken adı 
3 in 
4 de dizi adı olucak şekilde yapılır.

metodlar komutları bir araya toplayan yapıdır.
public ve private olarak yapıları vardır.
geriye deger döndüren ve geriye deger döndürmeyen adı altında iki ye ayrılır.

void kavramı geriye deger döndürmeyen metotlar da kullanılır boş geçersiz anlamı vardır.
geriye döndürmeyen metotlar da global alan da private viod .. () 
{
bu aranın içine istenilen işlem girilir.
} 
şeklinde yapılır 
 geri döndüren;
 
 int a (int b int c)
 {
int d = b*c
 }
 bu metedu a diyerek diger fonksiyonlar da kullanabiliriz.


sınıflar dersinde public ve private arasındaki farkı ögrendik. public nesnel olup çagrılabilir fakat private özel oldugu için tekraradan yeni bir süslü parantez için de fonksiyon vermemiz gerek mesela private int yıl dedik bunu cagıramayız fakat alt ta 



           public int YIL
        {
            get { return yıl; }
            set { yıl = Math.Abs(value); }
        }
        // burdaki math.abs value kodu matematik degerenin mutlak halını göndermesi için yazılmıştır.
        işlemini yaptıktan sonra çagırabiliriz.


oluşturalan sınıfın yanına gelip : yapıp diger sınıfla birleştirebilirsin.
mesela public string ARABA : ARABADETAY
bu iki sınıf birlikte kalıtım ile çalışır.