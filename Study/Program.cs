using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {      
        static void Text(string Text)
        {
            Console.WriteLine(Text);
        }

        static int NumResult(int num1, int num2)
        {
            return num1 * num2; 
        }

        static void Main(string[] args)
        {
            Text("Hi all here!");
            Console.WriteLine("Hi guys! ");

            Console.WriteLine("Please enter Num 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(NumResult(num1,num2));

            int[] myArray = { 12, 22, 45, 16 };
            int result = 0;
            foreach (var e in myArray)
            {
                result = e + 100;
            }
            Console.WriteLine(result);
        }

    }

}

