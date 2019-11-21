using System;

namespace _2_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the N: ");
            int N = Convert.ToInt32((Console.ReadLine()));
            int x;
            int y;
            int z;
            for (x = 1, y = 1, z = 1; ; x++)
            {
                _ = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N;
                if (true)
                {
                    Console.Write("\nThe result is: " + "x = " + x + ", y = " + y + ", z = " + z);
                }
                if (x == N)
                {
                    break;
                }
            }
            for (x = 1, y = 1, z = 1; ; y++)
            {
                _ = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N;
                if (true)
                {
                    Console.Write("\nThe result is: " + "x = " + x + ", y = " + y + ", z = " + z);
                }
                if (y == N)
                {
                    break;
                }
            }
            for (x = 1, y = 1, z = 1; ; z++)
            {
                _ = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N;
                if (true)
                {
                    Console.Write("\nThe result is: " + "x = " + x + ", y = " + y + ", z = " + z);
                }
                if (z == N)
                {
                    break;
                }
            }
        }
    }
}
