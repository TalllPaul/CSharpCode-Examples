using System;

namespace ArraysBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length - size of the array
            Console.WriteLine(numbers.Length);

            //IndexOf() - Index of element passed. In this example it returns 2 because 9 is in the index position 2, 0, 1, 2.
            Console.WriteLine(Array.IndexOf(numbers, 9));

            //Clear() - Clears the values between the start index and end index.
            Array.Clear(numbers, 0, 2);

            foreach(var item in numbers)
            {
                Console.Write(item + " ");
            }

            //Copy() - Copies the values of one array to another. Pass the origen array, destination array and length.
            int[] another = new int[] { 1, 2, 3 };
            Array.Copy(numbers, another, 1);

            foreach(var item in another)
            {
                Console.Write("COPIED: " + item + ", ");
            }

            //sort() - Sorts in ascending order.
            Array.Sort(numbers);

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            //reverse() - Outputs the values in decending order.
            Array.Reverse(numbers);
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
