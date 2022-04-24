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
            Console.WriteLine("Please Enter few words here:");
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

        static void Main(string[] args)
        {
            //Task 1:
            WelcomeMessage();
            string UserString = Console.ReadLine();
            WordSplitter(UserString);





        }

    }

}

