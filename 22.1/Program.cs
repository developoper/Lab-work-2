using System;

namespace _2_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A(x,y)");
            Console.Write("Enter Ax: ");
            int Ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Ay: ");
            int Ay = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nB(x,y)");
            Console.Write("Enter Bx: ");
            int Bx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter By: ");
            int By = Convert.ToInt32(Console.ReadLine());
            if (Ax > 0 && Ay > 0 && Bx > 0 && By > 0 || Ax < 0 && Ay > 0 && Bx < 0 && By > 0 || Ax < 0 && Ay < 0 && Bx < 0 && By < 0 || Ax > 0 && Ay < 0 && Bx > 0 && By < 0)
            {
                Console.Write("\nTrue");
            }
            else if (Ax == 0 || Ay == 0 || Bx == 0 || By == 0)
            {
                Console.Write("\nZero coord");
            }
            else
            {
                Console.Write("\nFalse");
            }
        }
    }
}
