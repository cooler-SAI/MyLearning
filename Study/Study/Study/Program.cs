namespace Study
{
    class Program
    {             
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Elves");
            list.Add("Gnomes");
            list.Add("Orcs");

            list.Insert(1, "Humans");
            foreach (string item in list)
            {
                Console.WriteLine($"\nRace is: {item} ");
            }
            Console.ReadLine();
        }
        
    }
  
}

