using System;

namespace NumbersDivisibleByThree
{
    /*
     * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
     */
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            for(int i = 1; i <= 100; i++)
            {

                if(i % 3 == 0)
                {
                    counter++;
                }

            }

            Console.WriteLine("Amount of numbers divisible by three between 1 and 100 are: " + counter);

        }
    }
}
