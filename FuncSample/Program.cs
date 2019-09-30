using System;
using System.Dynamic;

namespace FuncSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CompareMethods(number, PrimeCalculate.CheckPrimeNumber, PrimeCalculate.CheckPrimeWhile));

            Console.ReadLine();
        }

        private static bool CompareMethods(int number, Func<int, bool> forLoop, Func<int, bool> whileLoop)
        {
            bool bFor = forLoop(number);
            Console.WriteLine($"ForLoop: {bFor}");

            bool bWhile = whileLoop(number);
            Console.WriteLine($"WhileLoop: {bWhile}");

            return bFor == bWhile;
        }
    }
}
