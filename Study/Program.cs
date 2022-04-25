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
            
        
                
        static void Main(string[] args)
        {
            int[] myArray = { 22, 15, 16, 21, 30 };
            int result = IndexOf(myArray, 21);

            Console.WriteLine($" Element, that has this value is: {result} ");


        }

    }

}

