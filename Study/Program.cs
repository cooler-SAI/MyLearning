using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomize = new Random();

            int randomNumber = randomize.Next(100);
            Console.WriteLine(randomNumber);
        }
    }
}
