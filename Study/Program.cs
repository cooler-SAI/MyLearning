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

            int maxValue, minValue;

            if (firstNumber > secondNumber)
            {
                maxValue = firstNumber;
                minValue = firstNumber;
                Console.WriteLine($"MaxValue is : {firstNumber}");
                Console.WriteLine($"MinValue is : {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {                
                Console.WriteLine($"MaxValue is : {secondNumber}");
                Console.WriteLine($"MinValue is : {firstNumber}");
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
