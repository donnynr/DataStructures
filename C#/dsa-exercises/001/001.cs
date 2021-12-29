using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_exercises._001
{
    internal class _001
    {
        public int FindLowestIntNotPresent(int[] array) {
            int result = -1;

            SortedDictionary<int, int> possibleSolutions = new();

            if (!(array == null)) {
                if (array.Length > 0) {
                    
                    foreach (int i in array) {
                        if (i > 0)
                        {
                            if (!(possibleSolutions.ContainsKey(i + 1)))
                            {
                                possibleSolutions.Add(i + 1, -1);
                            }
                            else
                            {
                                possibleSolutions[i + 1] = i;
                            }
                        }   
                    }

                    foreach (KeyValuePair<int, int> pair in possibleSolutions)
                    {
                        if (pair.Value == -1)
                        {
                            result = pair.Key;
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
