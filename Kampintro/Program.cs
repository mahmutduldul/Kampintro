using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği 
            // do not repeat your self  - kendini tekrarlama
            
            string kategoriEtiketi="Kategori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.35;
            bool sistemGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artiş Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);




        }
    }
}
