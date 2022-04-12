using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int firstNumber = rand.Next(-10, 11);
            int secondNumber = rand.Next(-10, 11);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"MaxValue is : {firstNumber}");
                Console.WriteLine($"MinValue is : {secondNumber}");
            }
            else
            {
                Console.WriteLine($"MaxValue is : {secondNumber}");
                Console.WriteLine($"MinValue is : {firstNumber}");
            }


            Console.ReadLine();
        }
    }
}
