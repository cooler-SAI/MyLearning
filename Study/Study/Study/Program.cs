namespace Study
{
    class Program
    {
        private static void HashPrint(ref HashSet<string> Print)
        {
            foreach (var item in Print)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            var hash = new HashSet<string>();
            hash.Add ("1");
            hash.Add ("Server");
            hash.Add ("2");
            hash.Add ("coolOne!");

            HashPrint(ref hash);



        }
        
    }
  
}

