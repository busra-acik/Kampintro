using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaa başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            // array = dizi lerde bu bilgileri tutarız

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaa başlangıç için temel kurs","Java","Python","C#"};

            //kurslar.Length ile bu dizi içinde kaç eleman varsa onun sayısı kadar döner

            for (int i = 0; i <kurslar.Length; i++)// i sayaç 1 den başla 10 a kadar 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar) //dizi temelleri yapıları tek tek dönmeye yarıyor
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu = footer");
        }
    }
}
