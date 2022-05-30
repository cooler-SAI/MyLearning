
namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "") break;
                sum+=int.Parse(line);
                Console.WriteLine(line);
            }
            
           
        }
        
    }
  
}

