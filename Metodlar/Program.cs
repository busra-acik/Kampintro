using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun [] urunler = new Urun[] { urun1, urun2 };

            //Urun: veri tipi, urun:takma isim(urun1,urun2 ... tamamına kısaca urun dedik
            //urunler:dizimizin ismi
            //type-safe = tip güvenliği sebebiyle veri tipini yazıyoruz(Urun)
            foreach (Urun urun in urunler)

            { 
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("------------METOTLAR-------------");

            //instance = örnek class oluşturma
            //Metotlar bize aynı şeyi tekrar tekrar kullanabilme özelliği veriyor 
            //mesela aynı anda 5 farklı sayfaya sepete eklendi yazırdık
            
            //encapsulation = kapsülleme = ayrı ayrı yazılacak bir yapıyı düzene sokuyoruz
            //sepetmanagerde iki farklı metod kullandık ama 1. daha düzenli ve değişime açık oldu
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}

//Don't repeat yourself =DRY 
//clean code = Temiz kod  
//Best Practice = Doğru uygulama teknikleri
//METODLAR= tekrar tekrar kullanılabilirliği sağlayan kod blogları
