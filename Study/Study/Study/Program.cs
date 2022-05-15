namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Round double number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int DivideandRound(double a, double b)
        {
            return (int)Math.Round(a / b);
        }
        private static string GetGreetingMessage(string name, double salary)
        {
            return $"Hello, {name}, your salary is {Math.Ceiling(salary)}";

        }
        static void Print(int number)
        {
            Console.WriteLine(number);
        }
        static int GetSquare(int number)
        {
            return (int)Math.Pow(number, 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DivideandRound(8, 2));

            Console.WriteLine(GetGreetingMessage("Ander", 12000));

            Print(GetSquare(42));
        }

        
    }
}

