using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyvler = new string[] { };

            Product p1 = new Product();
            p1.Adi = "Elma";
            p1.Fiyati = 15;
            p1.Aciklama = "Amasya elması";

            Product p2 = new Product();
            p2.Adi = "Karpuz";
            p2.Fiyati= 80;
            p2.Aciklama = "Diyarbakır  Karpusu";

            Product[] products = new Product[] {p1,p2 };
            
            //type-safe-- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-------------METOTLAR---------");
            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(p1);
            sepetManager.Ekle(p2);


            sepetManager.Ekle2("Armut", "Yeşil armut", 12,11);
            sepetManager.Ekle2("İncir", "Kara incir", 11,11);
            sepetManager.Ekle2("Kavun", "Taze  Kavun", 10,11);

        }
    }
}

// Dont repeat youtself-DRY- Clean Code -Best Prectice