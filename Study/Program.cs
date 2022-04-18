using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // 27
            int[] myArray = { 10, 10, 43, 10 };

            int minValue = myArray.Where(e => e % 2 != 0).Sum();

            Console.WriteLine($"Minimun element value is {minValue}");
        }

    }
}
