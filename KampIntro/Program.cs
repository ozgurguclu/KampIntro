using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double dolarDun = 8.35;
            double dolarBugun = 8.52;
            if(dolarDun > dolarBugun)
                Console.WriteLine("Azalış");
            else if(dolarDun < dolarBugun)
                Console.WriteLine("Artış");
            else
                Console.WriteLine("Eşit");
        }
    }
}
