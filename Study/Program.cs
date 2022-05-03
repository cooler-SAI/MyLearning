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
            string text = "Hello Here!";
            Console.WriteLine($"{text} = {text.ToLower()}");

            char[] symbols = "Hi all here 2022!".ToCharArray();
            foreach (var item in symbols)
            {
                Console.Write($"{item}");
            }
            
        }

    }

}

