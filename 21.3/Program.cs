using System;

namespace _2_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, f1 = 1, f2 = 0, n = 999999999, q = 0;
            for (f = 1; f < n; f += 1)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
                Console.Write("Fib: " + f);
                if (f > 999 && f < 10000)
                {
                    q++;
                }
            }
            Console.WriteLine("\nQuantity of four digit numbers: " + q);
        }
    }
}
