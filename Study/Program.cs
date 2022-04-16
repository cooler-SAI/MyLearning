using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1:
            Console.WriteLine(" How many lines will be ? :");
            int linesNum;
            int.TryParse(Console.ReadLine(), out linesNum);

            Console.WriteLine(" How many columns will be ? :");
            int columsNum;
            int.TryParse(Console.ReadLine(), out columsNum);
            Console.WriteLine();

            int[,] mass = new int[linesNum, columsNum];
            Random rand = new Random();
            int elementSumCount = 0;

            for (int i = 0; i < linesNum; i++)
            {
                for (int j = 0; j < columsNum; j++)
                {
                    mass[i,j] = rand.Next(10);
                    Console.Write($"{mass[i,j]} ");
                                    }
                Console.WriteLine();
            }
            foreach (int e in mass)
            {
                elementSumCount += e;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of elements in array: {elementSumCount} ");

            //Task 2:
            Console.Write("Please Enter the lenght of your array:\t");
            int elementsUser = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] arrayUser = new int[elementsUser];

            for (int i = 0; i < arrayUser.Length; i++)
            {
                Console.Write($"Please, enter {i} element of your array:\t");
                arrayUser[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Result is :");

            for (int i = 0; i < arrayUser.Length; i++)
            {
                Console.Write($"{arrayUser[i]}");
                Console.WriteLine();
            }

            int minValley = arrayUser[0];
            for (int i = 1; i < arrayUser.Length; i++)
            {
                if (arrayUser[i] < minValley)
                {
                    minValley = arrayUser[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"your Min element is : {minValley}");

            //Task 3:
            Console.WriteLine("\t\t--------!!!GUESS NUMBER!!! v1.2-------");
            Console.WriteLine();
            Console.WriteLine("RULES: " +
                "\n* Player enter MAX number (any interger)" +
                "\n* Then CPU chose random, and Player try guess that number!" +
                "\n* CPU use tips for the Player" +
                "\n* If player tired, just Press 'Enter' button for exit. ");
            Console.WriteLine();
            Console.Write("Please enter MAX number:");
            int maxUserNum;
            int.TryParse(Console.ReadLine(), out maxUserNum);
            Console.WriteLine();

            Random rand = new Random();
            int AINumber = rand.Next(0, maxUserNum);

            while (true)
            {
                Console.WriteLine("Please try to guess the Number that CPU chose:");
                try
                {
                    int guessUserNum = int.Parse(Console.ReadLine());
                    if (guessUserNum == AINumber)
                    {
                        Console.WriteLine($"\nCONGRATZ!!! That's number is {AINumber}!!!!");
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    }
                    else if (guessUserNum < AINumber)
                    {
                        Console.WriteLine("\nNo! Your number < the Number that CPU chose! ");
                        Console.WriteLine();
                        continue;
                    }
                    else if (guessUserNum > AINumber)
                    {
                        Console.WriteLine("\nNo! Your number > the Number that CPU chose! ");
                        Console.WriteLine();
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"!!!! GAME OVER !!! The number is {AINumber} ");
                    Console.WriteLine();
                    break;
                }

                continue;

            }
        }

    }
}
