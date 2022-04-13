using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 10 to 0 :");
            int number = 0;
            while (number < 10)
            {
                Console.WriteLine($"{10 - number}");
                number++;
            }

            
        }
    }
}
