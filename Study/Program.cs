using System;
using System.Linq;
using System.IO;
using System.Threading;


namespace Study
{
    class Program
    {      
        
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"e:/info.txt");
            Console.WriteLine(text);

            Console.WriteLine("===================================");

            string [] text2 = File.ReadAllLines(@"e:/info.txt");
            foreach (var line in text2)
            {
                Console.WriteLine(line);
            }

        }

    }

}

