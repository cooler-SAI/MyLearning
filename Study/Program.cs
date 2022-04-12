using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomize = new Random();

            int x = randomize.Next(10, 20);

            Console.WriteLine(x);
        }
    }
}
