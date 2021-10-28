using System;

namespace KampIntro
{
    class Program 
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği veri tipi tanımlarken onun veri tipini yazmak zorundasın.
            //do not repeat yourself = kendini tekrarlama
            //kategoriEtiketi bir değer tutucu yani alias
            //yönetim dedi ki artık kategori değil kategoriler olsun..
            //ondalıklı sayılar double veri tipinde gösteriyoruz.

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 9.50;
            double dolarBugun = 9.60;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Kayıt Olunuz");
            }

            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}