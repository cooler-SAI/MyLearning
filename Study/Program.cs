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
            PrintLine("#", 10);

            Console.ReadKey();




        }

    }

}

