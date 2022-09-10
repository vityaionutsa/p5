using System;

namespace p10
{
    class Program
    {
        static void Main()
        {
            float a;
            Console.Write("a = ");
            a = Convert.ToSingle(Console.ReadLine());
            a = a % 10;
            Console.WriteLine(a);
        }
    }
}
