using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // 27
            Console.WriteLine("Enter the lenght of youe array:");
            int lenghtNum;
            int.TryParse(Console.ReadLine(),out lenghtNum);

            Random rand = new Random();
            int[] myArray = new int[lenghtNum];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(10);
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

    }
}
