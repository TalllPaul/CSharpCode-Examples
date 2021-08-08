using System;

namespace SumOfNumbersEntered
{
    /*
     *  Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
     *  */
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(true)
            {

                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();

                if(input.Equals("ok"))
                {
                    Console.WriteLine(num);
                    break;

                } else
                {
                    num += Convert.ToInt32(input);
                }

            }

        }
    }
}
