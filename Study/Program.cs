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

            foreach (var e in myArray)
            {
                Console.Write($"{e} ");
            }


            
        }

    }}