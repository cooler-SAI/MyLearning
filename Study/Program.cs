using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ander";
            string surName = "Shatohin";
            string age = "38";
            string specialization = "Intern";

            string pattern = "Name: {0}, \nSurname: {1}, \nAge: {2}, \nSpecialization: {3}";
            Console.WriteLine(pattern,
                              firstName,
                              surName,
                              age,
                              specialization);

            Console.ReadLine();
        }
    }
}
