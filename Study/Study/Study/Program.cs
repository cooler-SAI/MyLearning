namespace Study
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Dictionary<string, string> russian = new Dictionary<string, string>();

            russian.Add("Hello", "Привет");
            russian.Add("Bye", "ПОка");

            foreach (var item in russian)
            {
                Console.WriteLine(item);
            }
           




        }
        
    }
  
}

