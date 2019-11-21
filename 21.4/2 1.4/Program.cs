using System;

namespace _2_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter q: ");
            double q = Convert.ToDouble(Console.ReadLine());
            bool k = true;
            double cosx = 0, fact = 1, fact_res = 1;
            x = x * (Math.PI / 180.0);
            for (double term = 9999, i = 0; term > q; i++, k = !k)
            {
                fact = i != 0 ? 2 * i : 1;
                fact_res = 1;
                do
                {
                    fact_res *= fact;
                    fact--;
                }
                while (fact > 1);
                {
                    term = Math.Pow(x, 2 * i) / fact_res;
                }
                if (k)
                {
                    cosx += term;
                }
                else
                {
                    cosx -= term;
                }
            }
            x *= (180.0 / Math.PI);
            Console.Write("The result is: " + $"cos({x}) = {cosx: 0.000}");
        }
    }
}
