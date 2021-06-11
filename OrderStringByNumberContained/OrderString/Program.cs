using System;
using System.Collections.Generic;

/*
 * Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
https://www.codewars.com/kata/55c45be3b2079eccff00010f/csharp
 */

namespace OrderString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "is2 Thi1s T4est 3a";

            Console.WriteLine("Inputted: " + word);
            Console.WriteLine(OrderString(word));
        }

        public static string OrderString(string word)
        {
            if(word.Equals("null"))
            {
                return " ";
            }

           
            string[] array = word.Split(" ");
            string[] array2 = new string[9];

            foreach(var item in array)
            {

                if(item.Contains('1'))
                {
                    array2[0] = item;
                    //array2.Add(array[0]);

                } else if(item.Contains('2'))
                {
                    array2[1] = item;
                }
                else if (item.Contains('3'))
                {
                    array2[2] = item;
                }
                else if (item.Contains('4'))
                {
                    array2[3] = item;
                }
                else if (item.Contains('5'))
                {
                    array2[4] = item;
                }
                else if (item.Contains('6'))
                {
                    array2[5] = item;
                }
                else if (item.Contains('7'))
                {
                    array2[6] = item;
                }
                else if (item.Contains('8'))
                {
                    array2[7] = item;
                }
                else if (item.Contains('9'))
                {
                    array2[8] = item;
                }

            }

            string wordReturn = null;

            foreach(var item in array2)
            {
                wordReturn += item + " ";
            }
            return wordReturn.Trim();

        }
    }
}
