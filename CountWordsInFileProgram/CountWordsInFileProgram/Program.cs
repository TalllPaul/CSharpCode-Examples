using System;
using System.IO;

namespace CountWordsInFileProgram
{
    /*
     * 1- Write a program that reads a text file and displays the number of words.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\pandrews\countme.txt";

            //Checks if file exists or not 
            try
            {
                //if (File.Exists(path))
                // {
                //Console.WriteLine("File Exists");

                int counter = 0;

                var content = File.ReadAllText(path);

                var counted = content.Split(" ");

                foreach (var item in counted)
                {
                    counter++;
                }

                Console.WriteLine("{0} words", counter);

                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
