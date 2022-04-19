using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = 
            {
                {1,2,4,4,4 },
                {12,41,62,4,5 },
                {42,12,10,74,10 },
                {42,12,10,74,10 }

            };

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    Console.Write(myArray[h,w] + "\t");

                }
                Console.WriteLine();
            }
            

            
        }

    }}