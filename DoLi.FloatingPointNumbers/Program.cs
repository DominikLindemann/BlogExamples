using System;

namespace DoLi.FloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ResultFalse();
            Console.WriteLine("----------------------");
            ResultTrue();
            Console.ReadLine();
        }


        private static void ResultFalse()
        {
            double d1 = 1.000001F;
            double d2 = 0.000001F;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine((d1 - d2) == 1.0);
        }

        private static void ResultTrue()
        {
            decimal d1 = 1.000001M;
            decimal d2 = 0.000001M;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine((d1 - d2) == 1.0M);
        }
    }
}