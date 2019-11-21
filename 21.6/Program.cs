using System;

namespace _2_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
        label:
            try
            {
                Console.Write("Enter age: ");
                uint age = Convert.ToUInt32(Console.ReadLine());
                uint t1 = age % 10;
                if (t1 == 1 && age != 11 && age > 0 && age < 100)
                {
                    Console.Write(age + " год");
                }

                else if (t1 >= 2 && t1 <= 4 && age > 0 && age < 100)
                {
                    Console.Write(age + " года");
                }

                else if (age > 0 && age < 100)
                {
                    Console.Write(age + " лет");
                }
            }
            catch (FormatException)
            {
                Console.Write("Format exception. Please, enter the correct(s) value(s). ");
                goto label;
            }
        }
    }
}
