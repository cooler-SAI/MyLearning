using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter height of your Triangle:");
            int heightTriagle = int.Parse(Console.ReadLine());


            for (int i = 0; i < heightTriagle; i++)
            {
                for (int j = heightTriagle; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i <= heightTriagle; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

    }
}
