using System;

namespace metod_calculate
{
    internal class Program
    {
        public static void calculate(ref int a, ref int b, ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }

        private static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 30;

            Console.WriteLine("числа до деления " + a + " " + b + " " + c);

            calculate(ref a, ref b, ref c);

            Console.WriteLine("числа после деления " + a + " " + b + " " + c);

            Console.ReadLine();
        }
    }
}