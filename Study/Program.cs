using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {
        //Task 1:
        static void WelcomeMessage()
        {
            Console.WriteLine("Task1: \nPlease Enter few words here:");
        }

        static string[] WordSplitter(string UserString)
        {
            string[] UserSentence = UserString.Split(' ');
            foreach (var chars in UserSentence)
            {
                Console.WriteLine($"Substring: {chars}");
            }
            return UserSentence;
        }

        //Task 2:
        static void WelcomeMessage2()
        {
            Console.WriteLine("Task2: \nPlease Enter few words here:");
        }

        static string[] WordReverse(string UserString2)
        {
            string[] ConvertedSentence = UserString2.Split(' ');
            for (int i = 0; i < ConvertedSentence.Length; i++)
            {
                ConvertedSentence[i] = new string(ConvertedSentence[i].Reverse().ToArray());
            }
            Console.WriteLine(string.Join(" ", ConvertedSentence));
            return ConvertedSentence;
        }

        static void Main(string[] args)
        {
            //Task 1:
            WelcomeMessage();
            string UserString = Console.ReadLine();
            WordSplitter(UserString);
            Console.WriteLine();

            //Task 2:
            WelcomeMessage2();
            string UserString2 = Console.ReadLine();
            WordReverse(UserString2);
            Console.WriteLine();
            Console.ReadKey();


        }

    }

}

