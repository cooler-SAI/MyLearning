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
                        $"Имя_{i}",
                        $"Фамилия_{i}",
                        $"Должность_{i}",
                        (uint)random.Next(1000, 2000),
                        $"Отдел_{i}"));
            }

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
        }
        
    }
  
}

