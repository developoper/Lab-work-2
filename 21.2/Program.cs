using System;

namespace _2_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 0;
            bool plus = true;
            Console.Write("Enter the quantity of terms: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < quantity; i += 2)
            {
                if (plus)
                    pi += 1.0 / i;
                else
                    pi -= 1.0 / i;
                plus = !plus;
            }
            pi *= 4;
            Console.Write("The result is: " + pi);
        } 
    }
}
