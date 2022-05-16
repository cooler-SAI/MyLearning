namespace Study
{
    class Program
    {             
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            Random random = new Random();

            for (int i = 1; i < 10; i++)
            {
                workers.Add(
                    new Worker(
                        (int)random.Next(0,10),
                        DateTime.Now,
                        $"Worker Fullname_{i}",
                        random.Next(19,44),
                        random.Next(170, 182),
                        DateTime.Now,
                        $"Отдел_{i}"));
            }

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
        }
        
    }
  
}

