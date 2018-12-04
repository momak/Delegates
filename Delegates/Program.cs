using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Mashine m = new Mashine();

            //m.RegisterTempChange(LogToConsole);
            m.RegisterTempChange((prev, current) =>
            {
                Console.WriteLine($"Temp changed from {prev} to {current}");
            });

            //m.RegisterTempChange(LogToFile);
            m.RegisterTempChange((prev, current) =>
            {
                using (StreamWriter writter = new StreamWriter("temps.txt", true))
                {
                    writter.WriteLineAsync($"Temp changed from {prev} to {current}");
                }
            });

            m.TurnOn();

            Console.WriteLine("Hello World!");
        }

        private static void LogToConsole(double prev, double current)
        {
            Console.WriteLine($"Temp changed from {prev} to {current}");
        }

        private static void LogToFile(double prev, double current)
        {
            using (StreamWriter writter = new StreamWriter("temps.txt", true))
            {
                writter.WriteLineAsync($"Temp changed from {prev} to {current}");
            }

        }
    }
}
