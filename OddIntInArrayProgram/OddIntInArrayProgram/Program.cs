using System;

namespace OddIntInArrayProgram
{
    class Program
    {
        /*
         * https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp
         * 
         * Given an array of integers, find the one that appears an odd number of times.

           There will always be only one integer that appears an odd number of times.
         * */
        static void Main(string[] args)
        {

            var arr = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };


            Console.WriteLine(find_it(arr));
        }

        public static int find_it(int[] seq)
        {
            //This loops the array.
            foreach (var number in seq)
            {
                int count = 0;
                //Loops the array again
                foreach (int target in seq)
                {
                    //Checks if the value of the original loop is the same as the second loop, if it is, increment. 
                    if (number == target)
                    {
                        count++;
                    }

                }
                //Once count is 1 (meaning odd) it will return the number that has appeared the odd number of times.
                    if((count % 2) == 1)
                    {
                        return number;
                    }
            }
            return -1;
        }
    }
}
