using System.Diagnostics;


namespace dsa_exercises
{
    internal class _000_FindLowestIntNotPresent
    {
        public int FindLowestIntNotPresent(int[] array) {
            int result = -1;

            HashSet<int> dataProcesed = new();
            SortedDictionary<int, int> solutions = new();

            if (!(array == null)) {
                if (array.Length > 0) {
                    
                    foreach (int i in array) {
                        if (i > 0)
                        {
                            if (!dataProcesed.Contains(i))
                            {
                                dataProcesed.Add(i);
                                solutions.Add(i + 1, -1);
                            }
                                                       
                            if (solutions.ContainsKey(i))
                            {
                                solutions.Remove(i);
                            } 
                            
                            if(solutions.ContainsKey(i + 1) && dataProcesed.Contains(i + 1))
                            {
                                solutions.Remove(i + 1);
                            }
                            
                        }   
                    }

                    Console.WriteLine($"solutions count: {solutions.Count}");

                    result = solutions.First().Key ;
                   
                }
            }

            return result;
        }

        public void test()
        {
            int Min = -100000;
            int Max = 100000;
            int[] array = new int[100000000];
            Random randNum = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(Min, Max);
            }

            //int[] array = { 100, 200, 300, 100, 101, 105 };

            //int[] array = { 1,3,5,7,9,2, 4,6,8};

            //int[] array = { 1, 1 };

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine($"Array count : {array.Length}");

            stopwatch.Start();
            int result = FindLowestIntNotPresent(array);
            stopwatch.Stop();

            Console.WriteLine($"The lowest integer found was : {result}, execution time sec:  {stopwatch.ElapsedMilliseconds / 1000}");

        }
    }
}
