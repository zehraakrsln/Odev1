// See https://aka.ms/new-console-template for more information
using ConsoleApp1.classes;


araba a = new araba();
a.git();


Bmw bmw = new Bmw();
bmw.markaVitesyaz("Bmw","duz");

Porche po = new Porche();
po.markaVitesyaz("porche", "otomatik");



/*
 Soyut Sınıf (Abstract Class)

Nesne tabanlı programlamada sınıf hiyerarşisi oluşturulurken, bazen en tepede bulunan sınıf türünden nesneler programcılar için anlamlı olmayabilir. Hiyerarşinin en tepesinde bulunan sınıfın kendisinden türetilecek olan alt sınıflar için ortak bir arayüz (interface) görevi yapması istenebilir. Bunun için çözüm olarak oluşturulan metotlara ve sınıflara soyut metot (abstract method) ya da soyut sınıf (abstract class) denir. Soyut sınıflar büyük projelerde kullanılırlar ve kalıtım özelliğini kullanarak kod tekrarını azaltırlar. Soyut sınıflar diğer sınıflara taban olmak için kullanılırlar. Nesne türetemezler. Önlerine “abstract” sözcüğü yazılarak soyutlaştırılırlar. Önlerine "virtual" yazılmaz çünkü “abstract” sözcüğü uygulanan tüm sınıf ve metotlar zaten sanaldır.

Kullanırken dikkat edilmesi gerekenler:

•    Soyut sınıflar “abstract” türünden nesneler tanımlamazlar.
•    Soyut sınıflar içerilerinde soyut olmayan metotlar da barındırabilir ancak soyut metotlar sadece soyut sınıflar içerisinde bildirilebilir.
•    Soyut metotlar türeyen sınıfta mutlaka bildirilmelidir.
•    Soyut metotlar override edilmek zorundadırlar, aksi takdirde derleyici hatası alınır.
•    “Static” metotlar soyut olarak tanımlanamazlar.
•    Soyut sınıflar “private” olarak tanımlanamazlar ama “public” ve “protected” olarak tanımlanabilirler.
•    Soyut sınıflar “sealed” anahtar sözcüğü ile ifade edilemezler.  

public abstract class SoyutSınıf
{
       abstract public void Soyut_Metot();//gövdesi olmayan metot

       public void Soyut_Olmayan_Metot()  //gövdesi olan metot
     {
        //metot gövdesi      
      }
} 

Soyut sınıf  ve arayüz arasındaki farklar ve benzerlikler:
•    Arayüz içerisindeki tüm öğelerin “public” olması gerekirken soyut sınıflarda tüm öğelerin “public” olması zorunlu değildir.
•    Bir sınıf sadece bir soyut sınıftan miras olarak tanımlanabilir ancak birçok arayüz tarafından bildirilebilir.
•    Soyut sınıf ve arayüz için yazılacak olan soyut metotların gövdeleri bulunmaz.
•    Soyut sınıflar çoklu ortamı desteklemezler ancak arayüz destekler.
•    Soyut sınıflar kullanım hızı açısından arayüzden daha avantajlıdır.
•    Soyut bir sınıfın tüm metotları soyut yapılırsa arayüz olarak kullanılabilir.
*/

/*
 Abstraction
Abstraction implementasyon ayrıntılarını kullanıcıdan gizler. 
Abstract (soyut) kavramı yalnızca sınıflar ve metotlar ile kullanılır, değişkenler için kullanılmaz.
Herhangi bir metodu abstract olarak tanımlarsak, o metodun görevinin/uygulamasının (implementation) ilgili sınıfın alt sınıfında olması gerekir, çünkü abstract metotlar hiçbir zaman implementasyondan bahsetmez. 
*/

/*
 * 1.Çok Biçimlilik (Polimorfizm) Nedir ?

Bir temel sınıf özelliği ve metotlarını, temel sınıfın türetilen bir sınıfa aktardığımızda temel sınıfa ait metotları türemiş sınıf içerisinde de kullanabiliriz.
Ancak onun iki sınıfında aynı metot bulunduğunda temel sınıftaki metot kullanılacak, türemiş sınıftaki metot ise kullanılmayacak.
Temel sınıfa ait metotları türemiş sınıfta farklı biçimlerde tanımlayarak kullanmak için geçersiz kılmak ve sanal niteleyicilerini kullanmak gereklidir.
*/