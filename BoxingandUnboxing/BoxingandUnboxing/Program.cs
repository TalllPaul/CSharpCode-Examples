using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingandUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Boxing and Unboxing***");

            //Problems with the ArrayList are the different types it takes (it takes any object). If at runtime we try to get the second element and try to cast to an int it will give an error.
            //Add takes an object so if we insert a value type it will box it, and if we get it it will unbox.
            var list = new ArrayList();
            list.Add(1); //value type boxing
            list.Add("Mosh"); //reference: no boxing.
            list.Add(DateTime.Today); //Structure - boxing

            //Best to use list, has type safety because we specify a type constraint.
            var anotherList = new List<int>();

            
        }
    }
}
