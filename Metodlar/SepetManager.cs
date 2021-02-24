using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention = doğru isimlendirme
        //syntax = yazım şekilleri
        //Urun parametre, urun takma isim
        public void Ekle(Urun urun)//parantez görüyorsan bil ki bir metod çalışıyor 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi );
        
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
