using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][];
            myArray[0] = new int[5];
            myArray[1] = new int[10];
            myArray[2] = new int[15];

            myArray[1][9] = 55;

            Console.WriteLine(myArray[1][9]);
        }

    }}