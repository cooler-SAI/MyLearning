namespace HelloWorld
{
    class Program
    {
        static int DivideandRound(double a, double b)
        {
            return (int)Math.Round(a / b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DivideandRound(8, 2));

            Console.WriteLine();
        }
    }
}

