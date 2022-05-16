using System;
using System.Collections.Generic;

namespace Study
{
    public class WorkingRoom
    {
        //////////////////////////////////////////////////////////////////////
        // Task 1
        #region Methods
        /// <summary>
        /// Random fill List of numbers
        /// </summary>
        public void FillList(List<int> list)
        {
            Random random = new Random();
            int listSize = 100; // we added List size here
            int count = 0; // we set numbers counter here

            for (int i = 0; i<listSize; i++) 
            {
                list.Add(random.Next(0, 100)); // we fill List by Random numbers here
                count++; 
            }
            Console.WriteLine($"You have {count} numbers here: "); // we place number counter to console
        }
        /// <summary>
        /// Show List in Console
        /// </summary>
        /// <param name="list"></param>
        public void ShowList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($" {list[i]} "); // print all numbers to console
            }
        }
        /// <summary>
        /// Delete Range numbers in Console
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<int> DeleteRangeList(List<int> list)
        {
            int MinNumber = 25; // we set min here for start range of numbers
            int MaxNumber = 50; // we set max here for end range of numbers
            int count = 0; // we set numbers counter here

            for (int i = 0; i < list.Count; i++)
            {
                count++;
                if (list[i] >= MinNumber && list[i] <= MaxNumber)
                {
                    list.RemoveAt(i); // we delete numbers here
                                     
                }                               
            }
            Console.WriteLine($"\nYou have {count} numbers here: "); // we place number counter to console
            return list;            
        }
        #endregion
        //////////////////////////////////////////////////////////////////////





    }
}
