using System;

namespace p8
{
    class Program
    {
        static void Main()
        {
            float a, b, c, avg;
            Console.Write("a = ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToSingle(Console.ReadLine());
            avg = (a + b + c) / 3;
            Console.Write("result = ");
            Console.WriteLine(avg);
        }
    }
}
