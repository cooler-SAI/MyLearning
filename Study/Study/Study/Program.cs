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
            list.Insert(1, "Humans");

            list.Remove(list[1]);

            list.Sort();

            list.Add("Orcs");
            list.RemoveAt(4);

            foreach (string item in list)
            {
                Console.WriteLine($"\nRace is: {item} ");
            }
            Console.ReadLine();
        }
        
    }
  
}

