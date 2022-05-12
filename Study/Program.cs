using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            string path = @"data.csv";
            DataStore datastore = new DataStore(path);            
            while (true)
            {
                datastore.WelcomeMessage();
                Console.WriteLine(
                "Please Enter the Number:" +
                "\n" +
                "\n1: Show Worker by ID" +
                "\n2: Add new Worker Data " +
                "\n3: Delete Worker Data " +
                "\n4: Edit Worker Data " +
                "\n5: Show Worker Data by period" +
                "\n6: Show Worker Data by descending" +
                "\n7: Show Worker Data by ascending" +
                "\n8: About Program ");
                int UserChoise;
                int.TryParse(Console.ReadLine(), out UserChoise);                

                switch (UserChoise)
                {
                    case 1: datastore.ShowIDWorker();
                        break;
                    case 2: datastore.AddWorkerData();                        
                        break;
                    case 3: datastore.DeleteWorkerData();                        
                        break;
                    case 4: datastore.EditWorkerData();
                        break;
                    case 5: datastore.PeriodWorkerData();
                        break;
                    case 6: datastore.DescendingWorkerData();
                        break;
                    case 7: datastore.AscendingWorkerData();
                        break;                    
                    case 8:
                        Console.WriteLine(" Program Created by Ander (cooler-SAI)" +
                            "\n v 1.2 (12.05.2022) Stavropol City, Russia" +
                            "\n" +
                            "\n");

                        Console.ReadKey();
                        break;
                    default:
                        break;

                }
                datastore.Save();

            }
            




        }
    }
}
