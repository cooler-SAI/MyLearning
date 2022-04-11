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

            Console.WriteLine($"{firstName,10} {surName,15}");
            Console.WriteLine($"{age,10} {specialization,15}");

            Console.ReadLine();
        }
    }
}
