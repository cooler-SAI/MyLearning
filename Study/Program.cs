using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int inputData = int.Parse(Console.ReadLine());
            int outputData = (inputData < 0) ? 0 : inputData;

            Console.WriteLine(outputData);

            
        }

    }
}
