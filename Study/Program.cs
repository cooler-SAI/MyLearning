using System;
using System.Linq;
using System.Threading;


namespace Study
{
    class Program
    {
        static void Hello()
        {
            Console.WriteLine("Hello World!");
        }

         static void PauseMe()
        {
            Console.ReadLine();
        }

        static void Pause (int Interval)
        {
            Thread.Sleep(Interval * 1000);
        }


        static void Main(string[] args)
        {
            Hello();
            PauseMe();
            PauseMe()

        }

    }

}

