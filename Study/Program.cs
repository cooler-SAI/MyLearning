using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {
        static int Result( int num1, int num2)
        {
            return num1 + num2;
        }
        static int Result(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;
        }

        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 10;
            int num3 = 30;
            int result = Result(num1, num2);

            Console.WriteLine(result);


        }

    }

}

