using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            int value = 10;

            for (int e = 0; e < myArray.Length; e++)
            {
                myArray[e] = value++;
                Console.WriteLine(myArray);
            }





        }
    }
}
