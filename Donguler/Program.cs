using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args) 
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            // bu tip verileri dizilerde tutarız.

            string[] kurslar = new string[]{ "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java", "Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("@@@@@----@@@@@@");

            //foreach dizileri daha kolay dolaşmak için kullanırız.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}