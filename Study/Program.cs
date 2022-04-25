using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        public static void Hi (string Name)
        {
            Random rand = new Random();
            string text = string.Empty;

            switch (rand.Next(3))
            {
                case 0:
                    text = $"Hello,{Name}";
                    break;
                case 1:
                    text = $"Asshole,{Name}";
                    break;
                default:
                    text = $"Ullalaaa,{Name}";
                    break;
            }
            Console.WriteLine(text);
        }
        
        static void Main(string[] args)
        {
            Pause();            
            Hi("Ander");
        }

    }

}

