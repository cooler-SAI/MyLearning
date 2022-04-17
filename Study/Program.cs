using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            bool allowedPassword;

            Console.WriteLine("Enter the password, please:");
            string enteredPassword = Console.ReadLine();
            string storedPassword = "qwerty";

            //if (enteredPassword == storedPassword)
            //{
            //    allowedPassword = true;
            //}
            //else
            //{
            //    allowedPassword = false;
            //}

            allowedPassword = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(allowedPassword);

            
        }

    }
}
