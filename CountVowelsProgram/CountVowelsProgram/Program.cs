using System;
using System.Collections.Generic;

namespace CountVowelsProgram
{
    /*
     * Write a program and ask the user to enter an English word. 
     * Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", 
     * the program should display 6 on the console.
     * */
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word and I will count the vowels: ");
            var input = Console.ReadLine();

            int count = 0;

                //Loops over the string inputr
               for (int i = 0; i < input.Length; i++)
                {
                    //If it contains a vowel it increments the counter.
                    if (input[i].Equals('a') || input[i].Equals('e') || input[i].Equals('i') || input[i].Equals('o') || input[i].Equals('u'))
                    {
                        count++;

                    }
                }

            Console.WriteLine("There are {0} vowels in the word(s) entered.", count);


            //Another option, this declares a new char list and when it loops the input string it looks to see whether the list contains the letter of the input.
            #region
            /*
            //var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });

            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };


            foreach (var character in input)
            {
                if(vowels.Contains(character))
                {
                    count++;
                }
            }

            Console.WriteLine("There are {0} vowels in the word(s) entered. (from list)", count);
            */
            #endregion



        }
    }
}
