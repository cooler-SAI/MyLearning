using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Welcome to the Game 'What's the Number?-v_1.0----");
            Console.WriteLine("");
            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();
            Console.WriteLine("  RULES:" +
                              "\n* Computer (AI) guesses any number from 1 to 100" +
                              "\n* The Player must guess this number" +
                              "\n* Player enter any number from 1 to 100 into console" +
                              "\n* The Computer shows hints to the player" +
                              "\n  GOOD LUCK!");
            Console.WriteLine("");
            Console.WriteLine(" Press any key to START!");
            Console.ReadKey();
            Console.WriteLine("");

            Random rand = new Random();
            int AINumber = rand.Next(1, 101);
            int PlayerTryCount = 0;
            int PlayerNumber;

            for (; ;)
            {
                Console.WriteLine(" Enter any number from 1 to 100 : ");
                int.TryParse(Console.ReadLine(), out PlayerNumber);
                PlayerTryCount++;
                if (PlayerNumber < AINumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Entered number is less than specified, try again...");
                    Console.WriteLine("");
                }
                else if (PlayerNumber > AINumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" The entered number is greater than the given one, try again...");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine($" GRAT's! You WON! AI number is '{AINumber}'!!!!!" +
                                       "\n" +
                                      $"\n You tried to guess {PlayerTryCount} times!...");
                    Console.WriteLine("");
                }
                
            }
        }
    }
}
