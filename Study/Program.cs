using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Number N here:");
            int number = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[] RandomNumbers = new int[number];

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                RandomNumbers[i] = rand.Next(-6, 5);
                Array.Sort(RandomNumbers);
                Console.Write($"{RandomNumbers[i]}");
                Console.WriteLine("");
                
            }
            Console.ReadLine();

        }
    }
}
