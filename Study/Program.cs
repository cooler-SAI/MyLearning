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
            System.Console.WriteLine("Hello to all here!");
            
        }
                
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = NumResult(a, b);

            Console.WriteLine(c);

            ConsoleMessage();





        }

    }

}

