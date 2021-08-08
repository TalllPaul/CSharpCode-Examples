using System;
using System.Collections.Generic;

namespace CheckDuplicatesAndEmptyStringProgram
{
    /*
     * Write a program and ask the user to enter a few numbers separated by a hyphen. 
     * If the user simply presses Enter, without supplying an input, exit immediately; 
     * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
    
    */
    class Program
    {
        static void Main(string[] args)
        {
            var breakout = false;
            do
            {
                Console.WriteLine("Enter a few numbers separated by a hypen: ");
                var input = Console.ReadLine();

                var splitted = input.Split('-');
                var passTo = new List<string>();

                if (string.IsNullOrEmpty(input))
                {
                    breakout = true;
                }

                for (int i = 0; i < splitted.Length; i++)
                {

                    if (passTo.Contains(splitted[i]))
                    {
                        Console.WriteLine("Duplicate");
                        break;

                    }
                    else
                    {
                        passTo.Add(splitted[i]);
                    }

                }
            } while(breakout != true);

        }
    }
}
