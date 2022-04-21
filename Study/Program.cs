using System;
using System.Linq;


namespace Study
{
    class Program
    {
        static void PrintLine (char symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }
        static void Main(string[] args)
        {
            // Homework!
            Console.Write("Please enter the symbol:");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Please enter Number of Symbols:");
            uint symbolsCount = uint.Parse(Console.ReadLine());


            PrintLine(symbol, symbolsCount);

            Console.ReadKey();




        }

    }

}

