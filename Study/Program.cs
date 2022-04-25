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
            string userText = string.Empty;

            switch (rand.Next(3))
            {
                case 0:
                    userText = $"Hello,{Name}";
                    break;
                case 1:
                    userText = $"Asshole,{Name}";
                    break;
                default:
                    userText = $"Ullalaaa,{Name}";
                    break;
            }
            Console.WriteLine(Name);
        }
        
        static void Main(string[] args)
        {
            Pause();


            Console.WriteLine("Please Enter Your Name: ");
            string Name = Console.ReadLine();
            Hi(Name);
        }

    }

}

