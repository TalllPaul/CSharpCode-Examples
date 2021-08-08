using System;
using System.Collections.Generic;

namespace ConsecutiveNumbersStringsProgram
{
    /*
     * Write a program and ask the user to enter a few numbers separated by a hyphen. 
     * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
     * display a message: "Consecutive"; otherwise, display "Not Consecutive".
     * */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            //Split numbers at their hyphen.
            var splitted = input.Split('-');
            //Create new int list to save the numbers converted to int
            var nums = new List<int>();

            //Loop the string array and convert each value, add to int list.
            foreach(var item in splitted)
            {
                nums.Add(Convert.ToInt32(item));

            }
            //Sort the numbers
            nums.Sort();

            int num = 1;
            //Loop the number array. The loop starts at index 1 and then the if condition checks to see if the value at index I is different to the value at index
            //i - 1, adding 1 to the value, if it's different, it's not consecutive. EXAMPLE: Number at index 1 = 2, number at index -1 (0) + 1 = 2.
            for(var i = 1; i < nums.Count; i++)
            {
                Console.WriteLine("nums[i]: " + nums[i]);
                Console.WriteLine("nums[i -1] + 1: " + (nums[i -1] + 1));

                if(nums[i] != nums[i -1] + 1)
                {
                    Console.WriteLine("Not consecutive");
                    break;

                }
                num++;
            }
            //Check if they are consecutive
            if (num == nums.Count)
            {
                Console.WriteLine("Consecutive");
            }

        }
    }
}
