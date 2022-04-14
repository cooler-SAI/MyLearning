using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[] numbersConsole = new int[number];

            for (int i = 0; i < numbersConsole.Length; i++)
            {
                numbersConsole[i] = rand.Next(-5, 6);
                Console.Write($"{numbersConsole[i]} ");
            }
            Console.ReadKey();

        }
    }
}
