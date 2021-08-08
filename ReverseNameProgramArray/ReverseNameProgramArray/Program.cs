using System;

namespace ReverseNameProgramArray
{
    /*
     *  Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
     *  Display the reversed name on the console.
     *  */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**REVERSED NAME**");

            Console.Write("Enter your name: ");
            var input = Console.ReadLine();

            //Creates the char array the same lengh as the inputted value.
            var charArr = new char[input.Length];

            //Loops from the length of the inputted value decrementing each time.
            for(int i = input.Length; i > 0; i--)
            {
                //Adds to the char array each letter.
                charArr[input.Length - i] = input[i - 1];
            }

            //Converts the char array to a string to print out.
            var reversed = new string(charArr);

            Console.WriteLine("Reversed name: " + reversed);

            //SHORTER EASIER

            //Converts the inputted value straight to an array
            char[] testArr = input.ToCharArray();
            //Reverses using the class Array and reverse.
            Array.Reverse(testArr);
            //Converts to string to print out.
            string reversed2 = new string(testArr);
            Console.WriteLine(reversed2);

        }
    }
}
