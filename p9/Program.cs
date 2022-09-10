using System;

namespace p9
{
    class Program
    {
        static void Main()
        {
            float a, b, h, area;
            Console.Write("a = ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("h = ");
            h = Convert.ToSingle(Console.ReadLine());
            area = ((a + b) / 2) * h;
            Console.Write("area = ");
            Console.WriteLine(area);
        }
    }
}
