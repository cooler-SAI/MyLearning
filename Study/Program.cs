using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5];

            myArray[0, 4] = 99;

            Console.WriteLine(myArray[0,4]);
        }

    }}