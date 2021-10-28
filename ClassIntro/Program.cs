using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Berk Özmenekşe";
            kurs2.IzlenmeOrani = 94;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Beril Özmenekşe";
            kurs3.IzlenmeOrani = 99;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Aysen Özmenekşe";
            kurs4.IzlenmeOrani = 99;

            //Console.WriteLine("Kurs'un Adı" + " : "  + kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs'un Adı" +  " : "  + kurs.KursAdi + "  " + "Kursu Veren Eğitmen" + " : " + kurs.Egitmen);
            }

            //Console.WriteLine();
        }
    }

    class Kurs
    {
        public string KursAdi  { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}