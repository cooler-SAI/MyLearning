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
                RandomNumbers[i] = rand.Next(10);
            }

            int EvenNumbers = 0;
            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                if (RandomNumbers[i] % 2 == 0)
                {
                    EvenNumbers++;
                }
            }
            Console.WriteLine($"Summ of Even Numbers is: {EvenNumbers}");
        }
    }
}
