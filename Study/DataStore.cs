using System;
using System.IO;
using System.Linq;

namespace Study
{
    class DataStore
    {
        private readonly string _path;
        private int IDWorker;
        private Worker[] workers = new Worker[7]; // here Data for one worker
        #region Methods
        /// <summary>
        /// Welcome Message
        /// </summary>
        public void WelcomeMessage()
        {
            Console.WriteLine("============= WELCOME TO DIRECTORY of WORKERS =============");
        }

        /// <summary>
        /// Wrote First added Data to Console.
        /// </summary>
        /// <param name="UserString"></param>
        /// <returns></returns>
        public DataStore(string path)
        {
            _path = path;
            File.Open(path, FileMode.OpenOrCreate).Close();
            foreach (var line in File.ReadLines(path))
            {
                EditWorkersArray(Worker.Parse(line));
            }            
        }
        /// <summary>
        /// Show ID of Workers
        /// </summary>
        public void ShowIDWorker()
        {
            Console.WriteLine("Enter ID for search...\n");
            var id = int.Parse(Console.ReadLine()) - 1;

            if (id >= IDWorker)
                Console.WriteLine("Record not found.\n");
            else
                Console.WriteLine(workers[id]);
        }

        public void AddWorkerData()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"\nYour Current Date and Time is: {dateTime} ");
            Console.ReadKey();

            Console.WriteLine("\nPlease Enter 'FullName' of Worker: " +
                         "(example Shatokhin Andrey Sergeevich) ");
            string WorkerFullName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter 'Age' of Worker: (example 36) ");
            int WorkerAge;
            int.TryParse(Console.ReadLine(), out WorkerAge);

            Console.WriteLine("\nPlease Enter 'Height' of Worker: (example 179) ");
            int WorkerHeight;
            int.TryParse(Console.ReadLine(), out WorkerHeight);

            Console.WriteLine("\nPlease Enter 'Date of Birth' of Worker: (example 12.02.1986) ");
            DateTime WorkerDateofBirth;
            DateTime.TryParse(Console.ReadLine(), out WorkerDateofBirth);

            Console.WriteLine("\nPlease Enter 'Place of Birth' of User: (example Andreapol city) ");
            string WorkerPlaceofBirth = Console.ReadLine();

            NewWorker(new Worker(IDWorker + 1, DateTime.Now, WorkerFullName,
                WorkerAge, WorkerHeight, WorkerDateofBirth, WorkerPlaceofBirth));

        }
        /// <summary>
        /// We approve Workers Array here
        /// </summary>
        /// <param name="worker"></param>
        private void NewWorker(Worker worker)
        {
            if (IDWorker >= workers.Length)
            {
                Array.Resize(ref workers, workers.Length * 2);
            }
            workers[IDWorker++] = worker;
        }
        /// <summary>
        /// Delete Worker Data Here by ID
        /// </summary>
        public void DeleteWorkerData()
        {
            Console.WriteLine("\nPlease Enter ID of Worker for delete it: (example 1) ");            
            try
            {
                int ID = int.Parse(Console.ReadLine()) - 1;
                if (ID >= IDWorker) Console.WriteLine("\nID doesn't exist! ");

                for (int e = ID; e < workers.Length; e++)
                {
                    workers[e] = workers[e];
                    workers[e].id = e;
                }
                IDWorker--;
            }
            catch (Exception)
            {
                Console.WriteLine($"Error! Please Enter the ID: ");
            }            
            
        }
        public void EditWorkerData()
        {
            Console.WriteLine("\nPlease enter ID for Edit: ");
            Console.WriteLine("Notice: \n/skip for skip step\n/stop for cancel edit\n");
            var id = int.Parse(Console.ReadLine()) - 1;

            if (id >= IDWorker) Console.WriteLine("\nWARNING! ID not found! Try again: ");

            Console.WriteLine(workers[id]);

            Console.WriteLine("\nPlease Enter new Full name of Worker: ");
            workers[id].workerFullName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter new Age of Worker: ");
            workers[id].workerAge = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease Enter new Height of Worker: ");
            workers[id].workerHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease Enter new Date of birth Worker's: ");
            workers[id].workerDateofBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease Enter new Place of birth Worker's: ");
            workers[id].workerPlaceofBirth = Console.ReadLine();
        }
        public void PeriodWorkerData()
        {
            Console.WriteLine("\nPlease Enter start of period:");
            DateTime startTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease Enter end of period:");
            DateTime endTime = DateTime.Parse(Console.ReadLine());

            foreach (var worker in workers.Take(IDWorker)) Console.WriteLine(worker);
        }
        public void DescendingWorkerData()
        {
            foreach (var worker in workers.Take(IDWorker).OrderByDescending(worker => worker.addingTime))
                Console.WriteLine(worker);
        }

        public void AscendingWorkerData()
        {
            foreach (var worker in workers.Take(IDWorker).OrderBy(worker => worker.addingTime))
                Console.WriteLine(worker);
        }

        public void Save()
        {
            using (var sw = new StreamWriter(File.Open(_path, FileMode.OpenOrCreate))) 
            {
                foreach (var worker in workers.Take(IDWorker))
                {
                    sw.WriteLine(worker.WorkerDataLine());
                }                
            }
        }
        private void EditWorkersArray(Worker worker)
        {
            if (IDWorker >= workers.Length)
            {
                Array.Resize(ref workers, workers.Length * 2);

            }
            workers[IDWorker++] = worker;
        }

        public void ArrayPrint()
        {
            for (int e = 0; e < IDWorker; e++)
            {
                Console.WriteLine(workers[e].UserDataPrint());
            }
        }
        #endregion

    }
}
