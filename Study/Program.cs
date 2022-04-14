using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOne = new int[5] { 42, 16, 22, 60, 5 };

            int[] arrayTwo = new int[5] { 12, 3, 8, 42, 6 };



            Console.WriteLine($"your Array One Data: {arrayOne[0]} {arrayOne[1]} {arrayOne[2]} {arrayOne[3]} {arrayOne[4]}");
            Console.WriteLine($"your Array Two Data: {arrayTwo[0]} {arrayTwo[1]} {arrayTwo[2]} {arrayTwo[3]} {arrayTwo[4]}");
        }
    }
}
