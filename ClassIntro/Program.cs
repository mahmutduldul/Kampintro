using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            product item = new product();
            
            item.productCode = "A1";
            item.productName = "ASUS";
            item.productPrice = 35;

            product item2 = new product();

            item2.productCode = "A2";
            item2.productName = "DELL";
            item2.productPrice = 44;

            product item3 = new product();
            item3.productName = "HP";
            item3.productCode = "A3";
            item3.productPrice = 55;

            //Console.WriteLine(kurs1.kursAdi +":"+kurs1.egitmen);

            product[] products = new product[] {item,item2,item3};
            Console.WriteLine("Foreach İle \n");
            foreach (var i in products)
            {

                Console.WriteLine("Ürün Kodu :" + i.productCode);
                Console.WriteLine("Ürün Adı :"+i.productName);
                Console.WriteLine("Ürün Fiyatı :" + i.productPrice);
                Console.WriteLine("-----------------------------");

            }

            Console.WriteLine("While ile \n");
            int x = 0;
             while(x<products.Length)
                {
                Console.WriteLine("Ürün Kodu :" + products[x ].productCode);
                Console.WriteLine("Ürün Adı :" + products[x].productName);
                Console.WriteLine("Ürün Fiyatı :" + products[x].productPrice);
                Console.WriteLine("-----------------------------");
                x++;
            }
            Console.WriteLine("For ile \n");
            for (int j=0; j<products.Length;j++)
            {
                Console.WriteLine("Ürün Kodu :" + products[j].productCode);
                Console.WriteLine("Ürün Adı :" + products[j].productName);
                Console.WriteLine("Ürün Fiyatı :" + products[j].productPrice);
                Console.WriteLine("-----------------------------");
                x++;
            }
        }
    }

    class product
    {
        public string productCode{ get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

}
