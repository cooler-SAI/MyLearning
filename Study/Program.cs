using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[,] table = new int[4, 4];

            for (int i = 1; i < table.GetLength(0); i++)
            {
                int mult = 1;

                for (int j = 1; j < table.GetLength(1); j++)
                {
                    table[i, j] = rand.Next(1, 10);
                    mult *= table[i, j];
                    Console.Write($"{table[i,j],2} ");
                }
                Console.WriteLine($": {mult}");
            }
            
        }
    }
}
