using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static double UserNumber (double num1, double num2)
        {
            return num1 * num2;
        }
        
        static void Main(string[] args)
        {
            Pause();
            double num1 = 5;
            double num2 = 5;
            Console.WriteLine(UserNumber(num1, num2)); 
        }

    }

}

