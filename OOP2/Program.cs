using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual c1 = new Individual();
            {
                c1.Id = 1;
                c1.CustomerId = "1234";
                c1.FirtsName = "Mahmut";
                c1.LastName = "Düldül";
                c1.TcNo = "1234";




                //kodlama io

                Coorporate c2 = new Coorporate();
                {

                    c2.Id = 2;
                    c2.CustomerId = "12345";
                    c2.CompanyName = "Duldul.turizm";
                    c2.VergiNo = "12345";
                    

                }



                Customer c3 = new Individual();
                Customer c4 = new Coorporate();

                CustomerManager customerManager = new CustomerManager();
                customerManager.Add(c1);
                customerManager.Add(c2);
                customerManager.Add(c3);
                customerManager.Add(c4);





            }
                
        }
    }
}
