using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // 26
            Console.WriteLine("Hello! enter how many elements will be in Array:");
            int elements;
            int.TryParse(Console.ReadLine(), out elements);

            int[] myArray = Enumerable.Range(1, elements).ToArray();

            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            

           
            
        }

    }
}
