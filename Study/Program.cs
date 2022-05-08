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
        static void WelcomeRaceInfo()
        {
            Console.WriteLine("You can Choose Race Here:\n" +
                "\n1 - Humans = Glory Race"+
                "\n2 - Dwarfs = Glory Race"+
                "\n3 - Elves = Glory Race"
                );            
        }
        static void Main(string[] args)
        {
            Empire Faction1 = new Empire("Glory Race", "Strong Dwarfs", "Mighty Race");
            Console.WriteLine(Faction1.Info());
            Console.WriteLine();
            WelcomeRaceInfo();
            Console.WriteLine($"Hello, Player! Please choose your character class: 1, 2 or 3");
            string PlayerChoise = Console.ReadLine();
                       

            switch (PlayerChoise)
            {
                case "1":
                    Console.WriteLine("You chose Human!");
                    break;
                case "2":
                    Console.WriteLine("You chose Dwarf!");
                    break;
                case "3":
                    Console.WriteLine("You chose HighElve!");
                    break;
                default:
                    Console.WriteLine("Please made a choise again!");
                    break;
            }
            Console.ReadKey(); 

        }
    }
}
