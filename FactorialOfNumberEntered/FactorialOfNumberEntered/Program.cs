using System;

namespace FactorialOfNumberEntered
{
    /*
     * Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, 
     * if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
     * */
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;

            }

            Console.WriteLine("{0}! = {1}.", num, fact);

        }
    }
}
