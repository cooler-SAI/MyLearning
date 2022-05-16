using System;
using System.Collections.Generic;

namespace Study
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////
            // Task 1
            WorkingRoom workingroom = new WorkingRoom(); // link Methods here
            List<int> numbers = new List<int>(); // create List of numbers

            workingroom.FillList(numbers); // Random fill List of numbers
            workingroom.ShowList(numbers); // Show List in Console
            workingroom.DeleteRangeList(numbers); // Delete Range numbers in Console
            workingroom.ShowList(numbers); // Show List in Console

            Console.ReadKey();
            //////////////////////////////////////////////////////////////////////










        }
    }
}
