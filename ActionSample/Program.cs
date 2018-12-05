using System;

namespace ActionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> GetFibonacciSeries = x =>
            {
                int starter = 0, next = 1, number = 0;
                Console.Write($"{starter} {next}");
                for (int i = 2; i < x; i++)
                {
                    number = starter + next;
                    Console.Write($" {number}");
                    starter = next;
                    next = number;
                }
            };
            Console.WriteLine("Enter a length");
            int num = Convert.ToInt32(Console.ReadLine());
            GetFibonacciSeries(num);
            Console.ReadKey();
        }
    }
}
