using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ships
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("_______________WELCOME TO BATTLE SHIPS GAME!!! v1.2_______________");
            Console.WriteLine("");
            Console.WriteLine("Press any key to Continue....");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("RULES:" +
                "\n * Enter coordinates for defeat 5 Battle Ships" +
                "\n * You need to Enter A1 and B1 for use a bomb" +
                "\n * Our capitan sad you need to use A1 <=5 and B1<=5" +
                "\n * Simple word: use numbers from 1 to 5 if you wanna get a ship!");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...START THE GAME!");
            Console.WriteLine("");
            Console.ReadKey();
            while (true)
            {
                Console.WriteLine("Please Enter A1:");
                Console.WriteLine("");
                int valuePlayerA1;
                int.TryParse(Console.ReadLine(), out valuePlayerA1);
                Console.WriteLine("");
                Console.WriteLine("Please Enter B1:");
                Console.WriteLine("");
                int valuePlayerB1;
                int.TryParse(Console.ReadLine(), out valuePlayerB1);
                Console.WriteLine("");
                // Game Data
                // ship 1:
                int ship1A1 = 2;
                int ship1B1 = 2;
                // ship 2:
                int ship2A1 = 3;
                int ship2B1 = 5;
                // ship 3:
                int ship3A1 = 4;
                int ship3B1 = 3;
                // ship 4:
                int ship4A1 = 5;
                int ship4B1 = 1;
                // ship 5:
                int ship5A1 = 1;
                int ship5B1 = 4;

                if (valuePlayerA1 == ship1A1 && valuePlayerB1 == ship1B1)
                {
                    Console.WriteLine("You defeated SHIP_1! BOOM!!!");
                }
                else if (valuePlayerA1 == ship2A1 && valuePlayerB1 == ship2B1)
                {
                    Console.WriteLine("You defeated SHIP_2! BOOM!!!");
                }
                else if (valuePlayerA1 == ship3A1 && valuePlayerB1 == ship3B1)
                {
                    Console.WriteLine("You defeated SHIP_3! BOOM!!!");
                }
                else if (valuePlayerA1 == ship4A1 && valuePlayerB1 == ship4B1)
                {
                    Console.WriteLine("You defeated SHIP_4! BOOM!!!");
                }
                else if (valuePlayerA1 == ship5A1 && valuePlayerB1 == ship5B1)
                {
                    Console.WriteLine("You defeated SHIP_5! BOOM!!!");
                }
                else
                {
                    Console.WriteLine("You Missed! Bomb just flap into the water! Try again!");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
          
                
            
            


        }
    }
}
