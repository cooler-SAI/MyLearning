using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        #region WelcomeMessage
        static void WelcomeMessage()
        {
            Console.WriteLine("============= WELCOME TO DIRECTORY =============");
        }
        #endregion
        #region WordSplitter
        static string[] WordSplitter(string UserString)
        {
            string[] UserData = UserString.Split('#', ' ');
            foreach (var chars in UserData)
            {
                Console.Write($" {chars}");
            }
            return UserData;
        }
        #endregion
        static void Main(string[] args)
        {
            // Task 1
            while (true)
            {
                WelcomeMessage();
                Console.WriteLine("\n" +
                "\n Please Enter the Number:" +
                "\n" +
                "\n1: Enter New User! " +
                "\n2: Show All User Directory " +
                "\n3: About Program ");
                int UserChoise;
                int.TryParse(Console.ReadLine(), out UserChoise);

                string FilePath = @"d:\data.txt";

                switch (UserChoise)
                {
                    case 1:
                        DateTime dateTime = DateTime.Now;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter The following number: " +
                            "\n1: Enter New User Data" +
                            "\n2: Go Back to Main Menu" +
                            "\n" +
                            "\n");
                        int UserChoise1;
                        int.TryParse(Console.ReadLine(), out UserChoise1);
                        Console.Clear();
                        switch (UserChoise1)
                        {
                            case 1:
                                Console.WriteLine("\nPlease Enter 'ID' of User: (example 1) ");
                                string UserID = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"\nYour Current Date and Time is: {dateTime} ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("\nPlease Enter 'FullName' of User: " +
                                    "(example Shatokhin Andrey Sergeevich) ");
                                string UserFullName = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("\nPlease Enter 'Age' of User: (example 36) ");
                                string UserAge = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("\nPlease Enter 'Height' of User: (example 179) ");
                                string UserHeight = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("\nPlease Enter 'Date of Birth' of User: (example 12.02.1986) ");
                                string UserDateofBirth = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("\nPlease Enter 'Place of Birth' of User: (example Andreapol city) ");
                                string UserPlaceofBirth = Console.ReadLine();
                                Console.Clear();
                                string grille = "#";
                                string NewUserData = UserID + grille + dateTime + grille + UserFullName + grille + UserAge +
                                    grille + UserHeight + grille + UserDateofBirth + grille + UserPlaceofBirth;
                                Console.WriteLine("\nYour current User Data is: ");
                                Console.WriteLine();
                                WordSplitter(NewUserData);
                                Console.WriteLine();
                                Console.WriteLine("\nPress any key to save it into the file... data.txt");

                                File.AppendAllText(FilePath, NewUserData + Environment.NewLine);
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                break;
                            default:
                                break;
                        }
                        Console.Clear();
                        break;
                    case 2:
                        if (File.Exists(FilePath))
                        {
                            Console.WriteLine("User's Data is: ");
                            Console.WriteLine();
                            string UsersData = File.ReadAllText(FilePath);
                            WordSplitter(UsersData);

                        }
                        else
                        {
                            Console.WriteLine("\nUser's Data Empty, " +
                                "\nplease add New Users from Main Menu Option. ");

                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(" Program Created by Ander (cooler-SAI)" +
                            "\n v 1.0 (03.05.2022) Stavropol City, Russia" +
                            "\n" +
                            "\n");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        break;

                }
                continue;

            }





        }
    }
}
