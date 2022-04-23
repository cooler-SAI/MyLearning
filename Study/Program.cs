using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Task 1:

            Console.WriteLine("Please Enter few words here:");
            string UserString = Console.ReadLine();

            string[] subs = UserString.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }

        }

    }

}

