using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // 27
            int[] myArray = { 10, 15, 42, 80, 2 };

            int minValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine($"Minimun element value is {minValue}");
        }

    }
}
