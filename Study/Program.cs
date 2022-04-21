using System;
using System.Linq;


namespace Study
{
    class Program
    {
        static void PrintLine (string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }
        static void Main(string[] args)
        {
            // Homework!
            Console.WriteLine("Please enter the symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Please enter Number of symbols:");
            uint symbolsCount = uint.Parse(Console.ReadLine());


            PrintLine(symbol, symbolsCount);

            Console.ReadKey();




        }

    }

}

