using System.Linq;
using System.Xml.Linq;

namespace Study
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Task 1
            //////////////////////////////////////////////////////////////////////
            // Task 1
            //WorkingRoom workingroom = new WorkingRoom(); // link Methods here
            //List<int> numbers = new List<int>(); // create List of numbers

            //workingroom.FillList(numbers); // Random fill List of numbers
            //workingroom.ShowList(numbers); // Show List in Console
            //workingroom.DeleteRangeList(numbers); // Delete Range numbers in Console
            //workingroom.ShowList(numbers); // Show List in Console

            //Console.ReadKey();
            #endregion
            //////////////////////////////////////////////////////////////////////
            #region Task 2
            // Task 2
            //WorkingRoom workingroom = new WorkingRoom(); // we add methods here           
            //var phonebook = new Dictionary<string, string>(); // we create dictionary here

            //while (true)
            //{                
            //    workingroom.LoadPhoneBookData(ref phonebook); // we load PhoneBookData from file to memory here
            //    workingroom.MainMenuTitle(); // main menu logo
            //    Console.WriteLine("\nPlease enter the number for menu navigation: " +
            //    "\n 1 - Show all PhoneBook Data." +
            //    "\n 2 - Seach Number and User." +
            //    "\n 3 - Add Number and User." +
            //    "\n 4 - About Programm.");
            //    int UserChoise;
            //    int.TryParse(Console.ReadLine(), out UserChoise);

            //    switch (UserChoise)
            //    {
            //        case 1:Console.Clear();
            //            workingroom.PhoneBookData(phonebook);// show all PhoneBook
            //            break;
            //        case 2:
            //            workingroom.SearchNumberUser(phonebook);// search in PhoneBook by number
            //            break;
            //        case 3:
            //            workingroom.AddNumberUser(ref phonebook);// add new User with phone to PhoneBook
            //            break;
            //        case 4:
            //            Console.Clear();
            //            Console.WriteLine("Program Created by Ander(cooler-SAI)" +
            //                    "\n v 1.1 (18.05.2022) Stavropol City, Russia" +
            //                    "\n" +
            //                    "\nPress any key to continue..."); // about program
            //            Console.ReadKey();
            //            break;
            //        default:
            //            Console.WriteLine("\nWrong number! Please try again...");
            //            break;
            //    }                
            //    phonebook.Clear();
            //    Console.Clear();
            //}
            #endregion
            //////////////////////////////////////////////////////////////////////
            #region Task 3
            // Task 3
            //WorkingRoom workingroom = new WorkingRoom(); // we add methods here
            //var hashset= new HashSet<int>();

            //while (true)
            //{
            //    workingroom.MainMenuTitle();
            //    Console.WriteLine("\nPlease enter the number for menu navigation: " +
            //        "\n 1 - Show all Hash Data." +
            //        "\n 2 - Add Data to Hash" +
            //        "\n 3 - About Programm.");
            //    int UserChoise;
            //    int.TryParse(Console.ReadLine(), out UserChoise);
            //    switch (UserChoise)
            //    {
            //        case 1:workingroom.ShowHashData(hashset);
            //            break;
            //        case 2:workingroom.AddData(hashset);                           
            //            break;
            //        case 3:
            //            Console.Clear();
            //            Console.WriteLine("Program Created by Ander(cooler-SAI)" +
            //                    "\n v 1.0 (19.05.2022) Stavropol City, Russia" +
            //                    "\n" +
            //                    "\nPress any key to continue..."); // about program
            //            Console.ReadKey();
            //            break;
            //        default:
            //            Console.WriteLine("\nWrong number! Please try again...");
            //            break;
            //    }
            //    Console.Clear();
            //}
            #endregion
            //////////////////////////////////////////////////////////////////////
            #region Task 4
            // Task 4
            var UserDataFile = new XDocument(new XDeclaration("1.5", "utf-8", "no"),
                new XElement("UserData",
                UserData.GetUserData().Select(item => new XElement("FullName",
                new XAttribute("FullName", item.FullName),
                new XElement("UserAddress",
                    new XElement("Street", item.Street),
                    new XElement("HouseNumber", item.HouseNumber),
                    new XElement("FlatNumber", item.FlatNumber)),
                new XElement("UserPhones",
                    new XElement("MobilePhone", item.MobilePhone),
                    new XElement("HomePhone", item.HomePhone))))));

            UserDataFile.Save("UserData.xml");
            #endregion
            //////////////////////////////////////////////////////////////////////












        }
    }
}
