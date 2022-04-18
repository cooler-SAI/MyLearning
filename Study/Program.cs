using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // 27
            Console.Write("Please enter array leight:");
            int arrayNum = int.Parse(Console.ReadLine());
            int[] myArray = new int[arrayNum];

            Random rand = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Please enter the value for {i} element:");
                myArray[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Your array is:");
            Console.WriteLine();
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            
            
        }

    }
}
