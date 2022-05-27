
namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3 < 4;
            var b = 5 == 6;
            Console.WriteLine(a);

            var c = b && a;
            Console.WriteLine(c);
            Console.WriteLine(!c);
           
        }
        
    }
  
}

