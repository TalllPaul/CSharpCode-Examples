using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceAplphabetPosition
{
    class Program
    {
        /*
         * 
         * https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
         * 
         * Welcome.

            In this kata you are required to, given a string, replace every letter with its position in the alphabet.

            If anything in the text isn't a letter, ignore it and don't return it.

            "a" = 1, "b" = 2, etc.

            There are 26 letters in the alphabet.

        */
        static void Main(string[] args)
        {
            //Original string
            var word = "The sunset sets at twelve o' clock.";

            //Call alphabet method
            Console.WriteLine(AlphabetPosition(word)); 
        }

        private static string AlphabetPosition(string word)
        {
            //New string that saves the original but as lowercase.
            string word2 = word.ToLower();

            //List for the alphabet
            var alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            var returnedString = "";
            //Loops the string
            for(var i = 0; i < word2.Length; i++)
            {
                //Checks that it only returns the characters in the alphabet list. 
                if (alphabet.Contains(word2[i]))
                {
                    returnedString += alphabet.IndexOf(word2[i]) + 1 + " ";
                    
                    //Console.Write((alphabet.IndexOf(word2[i]) + 1) + " ");

                }

            }

            return returnedString.Trim();

        }
    }
}
