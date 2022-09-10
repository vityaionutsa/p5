using System;

namespace p15
{
    class Program
    {
        static void Main()
        {
            float[] a = new float[4];
            int n = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"num = ",i);
                a[i] = Convert.ToSingle(Console.ReadLine());
                if (a[i] < 0)
                {
                    n++;
                }
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
