using System.Collections;
using System.Collections.Generic;

namespace oopApp
{
    internal class practice
    {
        

        public void Collections() 
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });

            // Show number of items in ArrayList.
            System.Console.WriteLine("This collection has {0} items.", strArray.Count);
            System.Console.WriteLine();

            // Add a new item and display current count.
            strArray.Add("Fourth!");
            System.Console.WriteLine("This collection has {0} items.", strArray.Count);

            // Display contents.
            foreach (string s in strArray)
            {
                System.Console.WriteLine("Entry: {0}", s);
            }
            System.Console.WriteLine();
        }


    }
}
