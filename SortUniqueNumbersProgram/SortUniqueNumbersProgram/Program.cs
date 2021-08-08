using System;
using System.Collections.Generic;

namespace SortUniqueNumbersProgram
{
    /*
     *  Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
     *  display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, 
     *  sort them and display the result on the console.
     *  */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//UNIQUE NUMBERS\\\\");

            //Create List to store the numbers
            var list = new List<int>();

            //A loop that executes until the amount strored is 5.
            while (list.Count < 5)
            {
                Console.WriteLine("Enter a unique number: ");
                var input = Convert.ToInt32(Console.ReadLine());

                //Checks if the list contains the number entered. If it does, it doesn't add to the list and returns to the while condition with continue.
                if (list.Contains(input))
                {
                    Console.WriteLine("You've previously entered " + input);
                    continue;
                }
                //Adds number to the list.
                list.Add(input);
            }

            list.Sort();

            foreach(var item in list)
            {
                Console.Write(item);
            }

        }
    }
}
