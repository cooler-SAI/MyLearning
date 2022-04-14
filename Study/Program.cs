using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // homework_3.10
            // Task 1:
            Console.WriteLine("Please enter the number (only integer):");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber %2 ==0)
            {
                Console.WriteLine($"Your number is {userNumber}, it's Even!");
            }
            else
            {
                Console.WriteLine($"Your number is {userNumber}, it's Odd!");
            }

            // Task 2: (method "switch")
            Console.WriteLine(" Hello! How many cards do you have? ");
            int playerCards;
            int.TryParse(Console.ReadLine(), out playerCards);
            int cardsSumPoints = 0;

            for (int i = 1; i <= playerCards; i++)
            {
                Console.WriteLine($"Please enter the value of {i} card:");
                string cardValue = Console.ReadLine();
                int sumPoints = 0;

                switch (cardValue)
                {
                    case "2":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "3":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "4":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "5":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "6":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "7":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "8":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "9":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "10":
                        sumPoints = Convert.ToInt32(cardValue);
                        break;
                    case "J":
                        sumPoints = 10;
                        break;
                    case "Q":
                        sumPoints = 10;
                        break;
                    case "K":
                        sumPoints = 10;
                        break;
                    case "T":
                        sumPoints = 10;
                        break;
                    default:
                        Console.WriteLine("Please Enter numbers from 2 to 10, 'J', 'Q', 'K', 'T'");
                        break;
                }

                cardsSumPoints += sumPoints;
            }
            Console.WriteLine("Your cards Summ points is: " + cardsSumPoints);
            Console.ReadKey();

            // Task 2: (method "if")
            Console.WriteLine(" Hello! How many cards do you have? ");
            int playerCards;
            int.TryParse(Console.ReadLine(), out playerCards);
            int cardsSumPoints = 0;

            for (int i = 1; i <= playerCards; i++)
            {
                Console.WriteLine($"Please enter the value of {i} card:");
                string cardValue = Console.ReadLine();
                int sumPoints = 0;

                if (cardValue == "J" || cardValue == "Q" || cardValue == "K" ||
                    cardValue == "T" || cardValue == "10")
                {
                    sumPoints = 10;
                }
                else if (cardValue == "2" || cardValue == "3" || cardValue == "4" ||
                    cardValue == "5" || cardValue == "6" || cardValue == "7" ||
                    cardValue == "8" || cardValue == "9")
                {
                    sumPoints = Convert.ToInt32(cardValue);
                }

                cardsSumPoints += sumPoints;


            }
            Console.WriteLine("Your cards Summ points is: " + cardsSumPoints);
            Console.ReadKey();
            // Task 3: 
            while (true)
            {
                Console.WriteLine(" Please enter the number (only integer): ");
                int userNumber;
                int.TryParse(Console.ReadLine(), out userNumber);

                bool SimpleNumber = true;
                for (int i = 2; i <= userNumber / 2; i++)
                {
                    if (userNumber % i == 0)
                    {
                        SimpleNumber = false;
                        break;
                    }

                }
                if (SimpleNumber)
                {
                    Console.WriteLine($" The number {userNumber} is Simple");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine($" The number {userNumber} NOT Simple");
                    Console.WriteLine("");
                }
                continue;
            }




        }
    }
}
