using System;

namespace pr16
{
    class Program
    {
        static void Main()
        {
            float a;
            Console.Write("a = ");
            a=Convert.ToSingle(Console.ReadLine());
            if (a>=1 || a<=7)
            {
                switch(a)
                {
                    case 1: 
                        Console.WriteLine("Monday");
                        break;
                    case 2: 
                        Console.WriteLine("Tuesday"); 
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
            }
            if(a<1 || a>7)
            {
                Console.WriteLine("not valid");
            }
        }
    }
}
