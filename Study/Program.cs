using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter height of your Array:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter width of your Array:");
            int width = int.Parse(Console.ReadLine());

            int [,] myArray = new int [height, width];
            Random rand = new Random();

            for (int i = 0; i < height; i++)
            {
                               
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine($"Please Enter value height:{i} width:{j}");
                    myArray[i, j] = int.Parse(Console.ReadLine());                    
                }
                
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{myArray[i, j]} ");
                }
                Console.WriteLine();
            }



        }

    }}