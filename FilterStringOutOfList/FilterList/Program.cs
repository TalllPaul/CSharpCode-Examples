using System;
using System.Collections.Generic;
using System.Linq;

/*
 * In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
        ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
        ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
        ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}

https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/csharp
*/



namespace FilterList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new List<object>() { 1, 2, "a", "b" };

            Console.WriteLine(ListFilterer(list).ToString());

            Console.ReadKey();
        }

        public static IEnumerable<int> ListFilterer(List<object> listofElements)
        {

            var list2 = new List<object>();

            foreach (var item in listofElements)
            {

                if (item is int)
                {
                    list2.Add(item);
                }
            }

            return list2.OfType<int>().ToList();
        }

        /*
         * public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      List<int> results = new List<int>();
      
      foreach(var item in listOfItems)
      {
        if(item is int)
        {
          results.Add((int)item);
        }
      }
      
      return results;
   }
         * 
         * 
         * */
    }
}
