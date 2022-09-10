using System;

namespace p14
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("max: ");
                    Console.WriteLine(a);
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    Console.Write("max: ");
                    Console.WriteLine(b);
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    Console.Write("max: ");
                    Console.WriteLine(c);
                }

            }
        }
    }
}

