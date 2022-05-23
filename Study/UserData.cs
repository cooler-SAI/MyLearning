using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    public class UserData
    {
        // Task 4
        #region UserDataStructure
        public string FullName { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        private static List<string> UserDataStructure { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// User's input Data
        /// </summary>
        /// <returns></returns>
        public static List<string> UserInputData()
        {
            UserDataStructure = new List<string>();
            var ConsoleReadData = new[]
                {"Full Name", "Street", "House Number", "Flat Number", "Mobile Phone", "Home Phone"};

            foreach (var i in ConsoleReadData)
            {
                Console.WriteLine($"\nPlease,enter the {i}: ");
                Console.ReadKey();
                UserDataStructure.Add(Console.ReadLine());
            }

            return UserDataStructure;
        }
        public static IEnumerable<UserData> GetUserData()
        {
            UserDataStructure = UserInputData();

            return new List<UserData>
            {
                new UserData
                {
                    FullName = UserDataStructure.ElementAt(0),
                    Street = UserDataStructure.ElementAt(1),
                    HouseNumber = UserDataStructure.ElementAt(2),
                    FlatNumber = UserDataStructure.ElementAt(3),
                    MobilePhone = UserDataStructure.ElementAt(4),
                    HomePhone = UserDataStructure.ElementAt(5)
                }
            };
        }


        #endregion
    }
}
