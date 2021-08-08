using System;
using System.Collections.Generic;

namespace ListsBasics
{
    //Lists have dynamic sizes unlike Arrays that are fixed sizes. Inside the <> goes the datatype, objects, ints, strings etc.  You can initialise like an array with the 
    //object initialization curly braces. YOU CANT MODIFY THE COLLECTION IN A FOREACH YOU HAVE TO USE A FOR (to remove values for example).
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            //adds value to list
            list.Add(1);
            //Add more than one value at the same time with AddRange. Add range receives a IEnumerable which can be an array or a list. As you can see we pass an array and it gets added to the list.
            list.AddRange(new int[3] { 3, 3, 3 });


            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            //this Indexof looks for the index number of 3 starting from the index number 3, so the number 3 at index will be ignored.
            Console.WriteLine("Index of the number 3 starting from index 3: " + list.IndexOf(3, 3));
            //Looks for the last ocurrence of 3 and returns the index.
            Console.WriteLine("Index of the last number 3 in the List: " + list.LastIndexOf(3));

            //Cuentas los valores (como el Length de array)
            Console.WriteLine("Count: " + list.Count);

            //Insert the value to be removed (not the index)
            list.Remove(2);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Clear - Removes all elements from the list

            list.Clear();

            Console.WriteLine("Cleared: " + list.Count);
        }
    }
}
