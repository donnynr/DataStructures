using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Queue
{
    public class clsQueue
    {
        public void proceed() { 
            Queue<int> queue = new();
            queue.Enqueue(0);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"First Element in the queue {queue.Peek()}");
            queue.Dequeue();

            foreach (int i in queue) { 
                Console.WriteLine(i);
            }
            

        }
    }
}
