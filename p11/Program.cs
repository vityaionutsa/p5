using System;

namespace p11
{
    class Program
    {
        static void Main()
        {
            double n, digit,  num;
            Console.Write("Number = ");
            num=Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            n = Convert.ToDouble(Console.ReadLine());
            
            if (num / (Math.Pow(10, n-1)) >= 1)
            {
                digit =num/(Math.Pow(10,n-1))%10;
                
                Console.WriteLine($"Ansver\t{(int)digit}");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
