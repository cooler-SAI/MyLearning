
namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3 < 4;
            var b = 5 == 6;
            var c = b && a;

            if (!b)
            {
                Console.WriteLine($"{b} is result ");

            }
            else
            {
                Console.WriteLine(c);
            }
            
           
        }
        
    }
  
}

