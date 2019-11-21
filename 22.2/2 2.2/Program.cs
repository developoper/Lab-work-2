using System;

namespace _2_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
            Console.Write("Enter the number from 1 to 100000: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double d = num % 3;
            if (num >= 0 && num <= 100000 && d == 0)
            {
                Console.Write("True");
            }
            else if (num >= 0 && num <= 100000)
            {
                Console.Write("False");
            }
            else
            {
                goto label;
            }
        }
    }
}
