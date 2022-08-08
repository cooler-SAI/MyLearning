namespace Study
{
    internal class Program
    {
        private static void HelloHere(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                HelloHere(myArray, i + 1);
            }
            else
            {
                Console.WriteLine("The END here!!!");
            }
        }

        private static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };
            HelloHere(myArray);
        }
    }
}