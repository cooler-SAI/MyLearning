using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[8][];
            myArray[0] = new int[5];
            myArray[1] = new int[10];
            myArray[2] = new int[15];
            myArray[3] = new int[13];
            myArray[4] = new int[2];
            myArray[5] = new int[8];
            myArray[6] = new int[10];
            myArray[7] = new int[22];

            Random rand = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rand.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write($"{myArray[i][j]}  ");
                }
                Console.WriteLine();
            }
        }

    }}