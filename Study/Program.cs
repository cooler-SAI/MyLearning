using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {
        static int NumResult(int a, int b)
        {
            return a + b;
        }
        static void ConsoleMessage()
        {
            Console.WriteLine("Hello to all here!");
            
        }
        static void PrintSymbols(string symbol, uint count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }
        static void PrintText(string text)
        {
            Console.WriteLine(text);
        }
        static void UserWord()
        {
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = NumResult(a, b);

            Console.WriteLine(c);

            ConsoleMessage();

            Console.WriteLine("Please Enter the symbol: ");
            string symbol = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the counts: ");
            uint count = uint.Parse(Console.ReadLine());
            PrintSymbols(symbol, count);

            PrintText("\nHi all here!! ");


            PrintText("Enter test text");
            UserWord();


            Console.ReadKey();




        }

    }

}

