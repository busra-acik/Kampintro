using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği,veri türünü yazman gerek
            //tek tırnak kullanılmaz,; zorunludur!!
            //Do not repeat yourself = Kendini tekrarlama!! Bu amaçla değişken kullanıcaz
            //alias = değer tutucu 

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            //kayıt ol butonu için veri tipi boolean
            bool sistemeGirisYapmisMi = false; //bu bilgi veri kaynağından gelir

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");  
            }

            //if parantezi içindeki doğru ise blok çalışır

            if (sistemeGirisYapmisMi == true) //if yazıp iki kez tab bas parantezler çıkar

            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            

        }
    }
}
