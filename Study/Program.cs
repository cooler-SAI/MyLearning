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

            string pattern = "Name: {0}, Surname: {1}, Age: {2}, Specialization: {3}";
            Console.WriteLine(pattern,
                              firstName,
                              surName,
                              age,
                              specialization);

            Console.ReadLine();
        }
    }
}
