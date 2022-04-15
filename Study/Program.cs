using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[,] table = new int[4, 4];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = rand.Next(1, 10);
                    sum += table[i, j];
                    Console.Write($"{table[i,j],2} ");
                }
                Console.WriteLine($": {sum}");
            }
            
        }
    }
}
