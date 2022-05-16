﻿namespace Study
{
    struct Worker
    {
        #region WorkerStructure
        /// <summary>
        /// Id of Worker
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Date and time when worker added
        /// </summary>
        public DateTime addingTime { get; set; }

        /// <summary>
        /// Full name of Worker
        /// </summary>
        public string workerFullName { get; set; }

        /// <summary>
        /// Age of Worker
        /// </summary>
        public int workerAge { get; set; }

        /// <summary>
        /// Height of Worker
        /// </summary>
        public int workerHeight { get; set; }

        /// <summary>
        /// Date of birth Worker's
        /// </summary>
        public DateTime workerDateofBirth { get; set; }

        /// <summary>
        /// Place of birth Worker's
        /// </summary>
        public string workerPlaceofBirth { get; set; }

        #endregion

        #region ConstructorWorker
        public Worker(int ID, DateTime AddingTime, string WorkerFullName, int WorkerAge,
            int WorkerHeight, DateTime WorkerDateofBirth, string WorkerPlaceofBirth)
        {
            this.id = ID;
            this.addingTime = AddingTime;
            this.workerFullName = WorkerFullName;
            this.workerAge = WorkerAge;
            this.workerHeight = WorkerHeight;
            this.workerDateofBirth = WorkerDateofBirth;
            this.workerPlaceofBirth = WorkerPlaceofBirth;

        }
        #endregion
        #region Methods
        /// <summary>
        /// Console Print Info here
        /// </summary>
        /// <returns></returns>
        public string UserDataPrint()
        {
            return $"{this.id,15} {this.addingTime,15} {this.workerFullName,15} " +
                $"{this.workerAge,15} {this.workerHeight,10} {this.workerDateofBirth,15} " +
                $"{this.workerPlaceofBirth,15}";
        }        
        #endregion



    }
}
