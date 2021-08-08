using System;

namespace MaxNumberEntered
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by commas: ");
            string input = Console.ReadLine();

            var arr = input.Split(',');

            int max = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                var arrInt = Convert.ToInt32(arr[i]);
                if(arrInt > max)
                {
                    max = arrInt;
                }
            }

            Console.WriteLine(max);
        }
    }
}
