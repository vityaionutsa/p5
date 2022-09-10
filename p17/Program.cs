using System;

namespace p17
{
    class Program
    {
        static void Main()
        {
            int a, fuctorial=1,ab=1;
            Console.Write("a = ");
            a=Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<a;i++)
            {
                //if(fuctorial<=a)
                {
                    fuctorial = fuctorial*ab;
                    ab++;
                }
            }
            Console.WriteLine($"Ansver:\t{fuctorial}");
           
        }
    }
}
