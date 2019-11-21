using System;

namespace _2_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ax^2 + bx + c = 0
            label:
            try
            {
                Console.Write("Enter number a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number c: ");
                double c = Convert.ToDouble(Console.ReadLine());
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    string x0 = "x + i * y     x - i * y";
                    Console.Write("\nThe result is: " + x0);
                }
                else if (d == 0)
                {
                    double x = ((-b) + d) / 2 * a;
                    Console.Write("\nThe result is: " + "x = " + x);
                }
                else
                {
                    double x1 = ((-b) + d) / 2 * a;
                    double x2 = ((-b) - d) / 2 * a;
                    Console.Write("\nThe result is: " + "x1 = " + x1 + ", " + "x2 = " + x2);
                }
            }
            catch (FormatException)
            {
                Console.Write("Format exception. Please, restart the program and enter the correct(s) value(s). ");
                goto label;
            }
        }
    }
}
