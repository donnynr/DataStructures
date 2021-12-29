using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.HashTables
{
    internal class clsSortedList
    {
        
        public void proceed() {
            // Creates and initializes a new SortedList.
            SortedList<string, string> mySL = new();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");
            
            // Displays the properties and values of the SortedList.
            Console.WriteLine("mySL");
            Console.WriteLine("  Count:    {0}", mySL.Count);
            Console.WriteLine("  Capacity: {0}", mySL.Capacity);


        }

    }
}
