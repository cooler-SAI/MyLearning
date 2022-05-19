using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Study
{
    public class WorkingRoom
    {
        //////////////////////////////////////////////////////////////////////
        // Task 1
        #region Methods
        /// <summary>
        /// Random fill List of numbers
        /// </summary>
        //public void FillList(List<int> list)
        //{
        //    Random random = new Random();
        //    int listSize = 100; // we added List size here
        //    int count = 0; // we set numbers counter here

        //    for (int i = 0; i < listSize; i++)
        //    {
        //        list.Add(random.Next(0, 100)); // we fill List by Random numbers here
        //        count++;
        //    }
        //    Console.WriteLine($"You have {count} numbers here: "); // we place number counter to console
        //}
        ///// <summary>
        ///// Show List in Console
        ///// </summary>
        ///// <param name="list"></param>
        //public void ShowList(List<int> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.Write($" {list[i]} "); // print all numbers to console
        //    }
        //}
        ///// <summary>
        ///// Delete Range numbers in Console
        ///// </summary>
        ///// <param name="list"></param>
        ///// <returns></returns>
        //public List<int> DeleteRangeList(List<int> list)
        //{
        //    int MinNumber = 25; // we set min here for start range of numbers
        //    int MaxNumber = 50; // we set max here for end range of numbers
        //    int count = 0; // we set numbers counter here

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        count++;
        //        if (list[i] >= MinNumber && list[i] <= MaxNumber)
        //        {
        //            list.RemoveAt(i); // we delete numbers here                                     
        //        }
        //    }
        //    Console.WriteLine($"\nYou have {count} numbers here: "); // we place number counter to console
        //    return list;
        //}
        #endregion
        //////////////////////////////////////////////////////////////////////
        // Task 2
        #region Methods        
        ///// <summary>
        ///// Main screen Logo
        ///// </summary>
        ///// <param name="list"></param>
        ///// <returns></returns>
        //public void MainMenuTitle ()
        //{
        //    Console.WriteLine("\n======================= PHONE BOOK =======================" +
        //        "\n");
        //}
        ///// <summary>
        ///// Show All PhoneBook Data
        ///// </summary>
        ///// <param name="book"></param>
        //public void PhoneBookData(Dictionary<string, string> dictionary)
        //{            
        //    Console.WriteLine("\nPhoneBook Data: " +
        //        "\n");
        //    foreach (var line in dictionary) Console.WriteLine($"{line}");
        //    Console.WriteLine("\nPress any key to continue...");
        //    Console.ReadKey();
        //}
        ///// <summary>
        ///// Load All PhoneBook Data in memory
        ///// </summary>
        ///// <param name = "book" ></ param >
        //public void LoadPhoneBookData(ref Dictionary<string, string> dictionary)
        //{
        //    try
        //    {
        //        var lines = File.ReadAllLines(@"dictionary.csv");
        //        foreach (var line in lines)
        //        {
        //            var data = line.Split('\t'); // we create array here for work
        //            var key = data[0].Trim(); 
        //            var value = string.Join("", data.Skip(1)).Trim();
        //            dictionary[key] = value;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Error! Please load dictionary.csv or create NEW" +
        //            "Before run the Programm." +
        //            "\nPress any key to close the application...");
        //        Console.ReadKey();
        //    }

        //}
        ///// <summary>
        ///// Add Number and User to PhoneBook
        ///// </summary>
        ///// <param name="book"></param>
        //public void AddNumberUser(ref Dictionary<string, string> dictionary)
        //{
        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("\nPlease enter the Number for new User: " +
        //            "\nExample (x-xxx-xxx-xx-xx) " +
        //            "\nWhere x is number....");
        //        var AddNumber = Console.ReadLine();
        //        if (AddNumber == string.Empty)
        //        {
        //            Console.WriteLine("\nIncorrect format! Please try again. ");
        //            break;
        //        }
        //        while (true)
        //        {
        //            Console.Clear();
        //            Console.WriteLine("\nPlease enter the FullName for new User: " +
        //            "\nExample (Shatokhin Andrey Sergeevich) ");
        //            var AddName = Console.ReadLine();
        //            if (AddName == string.Empty)
        //            {
        //                Console.WriteLine("\nIncorrect format! Please try again. ");
        //                break;
        //            }
        //            Console.Clear();
        //            dictionary.Add(AddNumber, AddName);
        //            Console.WriteLine($"\nSuccess! New User added to PhoneBook!" +
        //                $"\nNew User Data is :" +
        //                $"\nNumber: {AddNumber} and Name: {AddName} ");
        //            Console.ReadKey();
        //            break;
        //        }
        //        break;
        //    }
        //    SavePhoneBookData(ref dictionary);
        //}
        ///// <summary>
        ///// Seach Number and User 
        ///// </summary>
        ///// <param name="book"></param>
        //public void SearchNumberUser(Dictionary<string, string> dictionary)
        //{
        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("\nPlease enter the Number for search User: " +
        //                "\nExample (x-xxx-xxx-xx-xx) " +
        //                "\nWhere x is number....");
        //        var key = Console.ReadLine();
        //        if (dictionary.TryGetValue($"{key}", out var value))
        //        {
        //            Console.Clear();
        //            Console.WriteLine($"Result is: " +
        //                $"\nNumber: {key} " +
        //                $"\nUser: {value} ");
        //            Console.WriteLine("\nPress any key to continue...");
        //            Console.ReadKey();
        //        }
        //        else
        //        {
        //            Console.WriteLine("\nIncorrect Data! Please try again...");
        //            Console.WriteLine("\nPress any key to continue...");
        //            Console.ReadKey();
        //        }
        //        break;
        //    }

        //}
        ///// <summary>
        ///// Save Dictionary (PhoneBook) into the file
        ///// </summary>
        ///// <param name="dictionary"></param>
        //public void SavePhoneBookData(ref Dictionary<string, string> dictionary)
        //{
        //    using (var streamWriter = new StreamWriter(@"dictionary.csv"))
        //    {
        //        foreach (var keyValue in dictionary) 
        //            streamWriter.WriteLine($"{keyValue.Key}\t{keyValue.Value}");
        //    }
        //}
        #endregion
        //////////////////////////////////////////////////////////////////////
        // Task 3
        #region Methods 
        /// <summary>
        /// Main screen Logo
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public void MainMenuTitle()
        {
            Console.WriteLine("\n======================= HASH DATA =======================" +
                "\n");
        }
        /// <summary>
        /// Add Data into the HashSet
        /// </summary>
        /// <param name="hashset"></param>
        public void AddData(HashSet<int> hashset)
        {
            Console.Clear();
            Console.WriteLine("\nPlease enter the number: ");

            while (true)
            {
                var UserNumber = Console.ReadLine();
                if (int.TryParse(UserNumber, out var value))
                {
                    if (!hashset.Contains(value))
                    {
                        Console.WriteLine($"\nYour number is {UserNumber} added to Hash.");
                        hashset.Add(value);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{value} already in Hash.");
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                }
                else
                {                    
                    Console.WriteLine("\nError! Please enter the number again... ");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                }
            }            
        }
        /// <summary>
        /// Show HashSetData into console
        /// </summary>
        /// <param name="hashset"></param>
        public void ShowHashData(HashSet<int> hashset)
        {
            Console.WriteLine("Your HashSet:\n");
            foreach (var e in hashset)
            {
                Console.Write($"HashSet Data is:{e} ");
            }
                
        }
        #endregion
        //////////////////////////////////////////////////////////////////////
    }
}
