using System;
using System.Globalization;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double d = 10.2456524;
            Console.WriteLine(d.ToString("#.###"));

            Console.ReadLine();
        }
    }
}
