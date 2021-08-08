using System;
using System.Collections.Generic;

namespace EnterNumberUntilQuitProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            //List to store numbers
            var list = new List<string>();

            //Loop, while input is different to Quit, loop.
            while(!input.Equals("Quit"))
            {

                Console.WriteLine("Enter a number: ");
                input = Console.ReadLine();
                list.Add(input);
            }
            //New list to store the unique numbers
            var list2 = new List<string>();

            foreach(var item in list)
            {
                //if the unique list contains the number in list, don't add.
                if(!list2.Contains(item))
                {
                    list2.Add(item);
                }
                
            }

            //Print uniques.
            foreach(var item in list2)
            {
                Console.WriteLine("UNIQUES:" + item);
            }
        }
    }
}
