using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static int Result(int a,int b)
        {
            return a * b;
        }

        static void Info()
        {
            Console.WriteLine("Result Here!");
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;


            int c = Result(a, b);


            Info();


            Console.WriteLine(c);


        }

    }

}

