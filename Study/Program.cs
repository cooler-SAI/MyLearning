using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {
        static int IndexOf( int[] UserArray, int num)
        {
            for (int i = 0; i < UserArray.Length; i++)
            {
                if (UserArray[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
        static int[] GetRandomArray (uint Length, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] UserArray = new int[Length];

            for (int i = 0; i < UserArray.Length; i++)
            {
                UserArray[i] = rand.Next(minValue, maxValue);
            }
            return UserArray;

        }
            
        
                
        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 10);
            int result = IndexOf(myArray, 21);

            Console.WriteLine($" Element, that has this value is: {result} ");


        }

    }

}

