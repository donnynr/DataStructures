using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Stack
{
    public class clsStack
    {
        public void proceed(){
            Stack<int> mystack = new Stack<int>();
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);

            Console.WriteLine($"Next Item to pop {mystack.Peek()}");
            mystack.Pop();
            
            foreach (int i in mystack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
