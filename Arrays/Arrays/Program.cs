using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            int[] arr = new int[3];

            arr[0] = 1;
            arr[1] = 11;

            //non initialized elements are 0
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            //Bool array
            var BoolAr = new bool[3];

            BoolAr[0] = true;

            //Non initialized elements are false
            Console.WriteLine(BoolAr[0]);
            Console.WriteLine(BoolAr[1]);
            Console.WriteLine(BoolAr[2]);

            var stringArray = new string[3] { "Bob", "Dave", "Steve" };

            Console.WriteLine(stringArray[0]);
            Console.WriteLine(stringArray[1]);
            Console.WriteLine(stringArray[2]);
        }
    }
}
