using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {            // 27

            int[] myArray = { 20, 13, 22, 2 };

            int[] result = myArray.OrderByDescending(e => e).ToArray();

            int elementSumm = myArray.Sum();
            Console.WriteLine(elementSumm);
        }

    }}