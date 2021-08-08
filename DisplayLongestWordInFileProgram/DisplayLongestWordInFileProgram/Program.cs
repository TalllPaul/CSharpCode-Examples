using System;
using System.IO;

namespace DisplayLongestWordInFileProgram
{
    /*
     * Write a program that reads a text file and displays the longest word in the file.
     * */

    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:/Users/pandrews/countme.txt";

            var content = File.ReadAllText(path);

            var splitUp = content.Split(" ");

            int size = splitUp[0].Length;

            for(int i = 0; i < splitUp.Length; i++)
            {

                if(splitUp[i].Length > size)
                {
                    size = splitUp[i].Length;
                }

            }

            Console.WriteLine("The longest string is {0} ", size);

        }
    }
}
