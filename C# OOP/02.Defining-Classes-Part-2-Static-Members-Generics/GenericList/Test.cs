/* Problem 5. Generic class
 * Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
 */

namespace GenericList
{
    using System;

    class Test
    {
        static void Main()
        {
            // Declare a list of type int 
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            Console.WriteLine(intList.ToString());
            for (int i = 0; i < intList.Count; i++)
            {
                int element = intList[i];
                Console.WriteLine(element);
            }

            Console.WriteLine();

            // Declare a list of type string
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("C#");
            stringList.Add("Java");
            stringList.Add("PHP");
            stringList.Add("SQL");
            Console.WriteLine(stringList.ToString());
            for (int i = 0; i < stringList.Count; i++)
            {
                string element = stringList[i];
                Console.WriteLine(element);
            }

            Console.WriteLine();

            // Access element by index
            int index1 = 1;
            int index2 = 3;
            Console.WriteLine("Value of index {0} at intList: {1}", index1, intList.IndexOf(index1));
            Console.WriteLine("Value of index {0} at stringList: {1}", index2, stringList.IndexOf(index2));

            Console.WriteLine();

            // Removing element by index
            stringList.RemoveAt(index2);
            Console.WriteLine("Element of index {0} at stringList removed".ToString(), index2);
            for (int i = 0; i < stringList.Count; i++)
            {
                string element = stringList[i];
                Console.WriteLine(element);
            }

            Console.WriteLine();

            // Insert element
            stringList.Insert(2, "Python");
            Console.WriteLine("Inserted new element");
            Console.WriteLine(stringList.ToString());
            for (int i = 0; i < stringList.Count; i++)
            {
                string element = stringList[i];
                Console.WriteLine(element);
            }

            Console.WriteLine();

            // Clear the list
            intList.Clear();
            Console.WriteLine("intList cleared");
            Console.WriteLine(intList.ToString());
            for (int i = 0; i < intList.Count; i++)
            {
                int element = intList[i];
                Console.WriteLine(element);
            }

            Console.WriteLine();

            // Find element by its value
            stringList.Find("PHP");

            Console.WriteLine();

            // Auto-grow the array
            for (int i = 0; i <= 5000; i++)
            {
                intList.Add(i);
            }
            Console.WriteLine("intList auto-grown");
            Console.WriteLine(intList.ToString());

            Console.WriteLine();

            // Find minimal value
            Console.WriteLine("Minimal value of stringList is {0}", stringList.Min());

            // Find maximal value
            Console.WriteLine("Maximal value stringList is {0}", stringList.Max());

            // Find minimal value
            Console.WriteLine("Minimal value of intList is {0}", intList.Min());

            // Find maximal value
            Console.WriteLine("Maximal value intList is {0}", intList.Max());

            Console.WriteLine();
        }
    }
}