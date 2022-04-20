using System;
using System.Linq;

namespace Study
{
    class Program
    {
        static int Sum (int a, int b)
        {
            return  a + b;
        }

        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Sum(a, b);
            Console.WriteLine(Sum(a, b));
        }

    }}