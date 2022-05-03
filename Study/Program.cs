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
            
        }

    }

}

