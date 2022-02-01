using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_exercises
{
    internal class _001FindMinimumCarsNeeded
    {
        public int FindMinimumCarsNeeded(int[] people, int[] cars)
        {
            int carsNeeded = 0;
            int totalPeople = 0;
            SortedDictionary<int, int> carsOrdered = new();
          
            for (int i = 0; i < people.Length; i++)
            {
                totalPeople += people[i];
            }

            for (int i = 0;i < cars.Length; i++)
            {
                if (!carsOrdered.ContainsKey(cars[i]))
                {
                    carsOrdered.Add(cars[i], 1);
                }
                else
                {
                    carsOrdered[cars[i]]++;                     
                }
            }

            while (totalPeople > 0 && carsOrdered.Count > 0)
            {
                if (totalPeople <= carsOrdered.Last().Key * carsOrdered.Last().Value) {
                    carsNeeded += (int)Math.Ceiling((decimal)totalPeople / (carsOrdered.Last().Key * carsOrdered.Last().Value) * carsOrdered.Last().Value);
                    totalPeople = 0;
                }
                else
                {
                    totalPeople -= carsOrdered.Last().Key * carsOrdered.Last().Value;
                    carsNeeded += carsOrdered.Last().Value;
                    carsOrdered.Remove(carsOrdered.Last().Key);
  
                }
                
            }
            return carsNeeded;

        }

        public void test()
        {
            int Min = 1;
            int Max = 9;
            int[] people = new int[100000000];
            int[] cars = new int[100000000];

            Random randNum = new Random();

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = randNum.Next(Min, Max);
            }

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = randNum.Next(Min, Max);
            }

            //int[] people = { 2,3,4,2 };

            //int[] cars = {2,5,7,2};

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            int result = FindMinimumCarsNeeded(people, cars);
            stopwatch.Stop();
            
            Console.WriteLine($"The minimum cars needed are : {result}, execution time sec:  {stopwatch.ElapsedMilliseconds / 1000}");


        }
    }
}
