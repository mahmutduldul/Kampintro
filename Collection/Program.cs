using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] name = new string[] { "mahmut", "mehmet", "ekrem" };
            //console.writeline(name[0]);
            //console.writeline(name[1]);
            //console.writeline(name[2]);


            List<string> isimler2 = new List<string> { "Mahmut", "Kemal", "Yeliz" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Enes");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);


        }
    
    
    
    
    }
}
