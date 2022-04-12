using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int OutsideTemp = rand.Next(-10, 20);
            if (OutsideTemp <= 0)
            {
                Console.WriteLine("Cold outside! get a warm clothes");
            }
            else
            {
                Console.WriteLine("It's hot! Get Lightweight clothing");
            }

            Console.ReadLine();
        }
    }
}
