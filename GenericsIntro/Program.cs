using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Özgür");
            Console.WriteLine(isimler.Length);
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

            foreach (string isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
