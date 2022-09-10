using System;

namespace p12
{
    class Program
    {
        static void Main()
        {
            int a;
            Console.Write("Num:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 20)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
