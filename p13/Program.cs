using System;

namespace p13
{
    class Program
    {
        static void Main()
        {
            int a; 
            bool result;
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 9 == 0 || a % 13 == 0 || a % 11 == 0)
            {
                result=true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine(result);
        }
    }
}
