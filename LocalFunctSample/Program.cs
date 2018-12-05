using System;

namespace LocalFunctSample
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a number to calculate factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            long fact = GetFactorial(num);
            Console.WriteLine($"{num} factorial is {fact}");
            long GetFactorial(int number)
            {
                return number == 0 ? 1 : number * GetFactorial(number - 1);
            }
            Console.ReadKey();
        }
    }
}
