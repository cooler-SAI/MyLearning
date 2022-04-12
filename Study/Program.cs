using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // homework_2.7
            //Task 1:
            string FullName = "Shatohin Andrey";
            int userAge = 36;
            string userEmail = "coolerme86@gmail.com";
            double userITScore = 100.8;
            double userMathScore = 80.9;
            double userPhysicsScore = 88.7;
            Console.WriteLine($"\nName: {FullName}" +
                              $"\nAge: {userAge}" +
                              $"\nemail: {userEmail}" +
                              $"\nITScore: {userITScore}" +
                              $"\nMathScore: {userMathScore}" +
                              $"\nPhysicsScore: {userPhysicsScore}");
            Console.WriteLine("Press any Key to Continue!");
            Console.ReadKey();
            Console.WriteLine("-------------------------------------------");
            string UserData = "Name: {0} Age: {1} email: {2} ITScore: {3} MathScore: {4} PhysicsScore: {5}";
            Console.WriteLine(UserData,
                              FullName,
                              userAge,
                              userEmail,
                              userITScore,
                              userMathScore,
                              userPhysicsScore);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Press any Key to Continue!");
            Console.ReadKey();
            // Task 2:
            double SumScore;
            SumScore = userITScore + userMathScore + userPhysicsScore;
            double MidleScore;
            MidleScore = (userITScore + userMathScore + userPhysicsScore) / 3;
            Console.WriteLine($"SumScore: {SumScore,10}");
            Console.WriteLine($"MidleScore: {MidleScore,19}");
        }
    }
}
