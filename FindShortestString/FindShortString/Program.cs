using System;

/*
 * Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
*/
namespace FindShortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "bitcoin take over the world maybe who knows perhaps";

            Console.WriteLine("Shortest word has: {0}", FindShort(phrase));


        }

        public static int FindShort(string word)
        {
            string[] array = word.Split(" ");

            int num1 = array[0].Length;

            for(int i = 0; i < array.Length; i++)
            {

                int num = array[i].Length;
               

                if(num < num1)
                {
                    num1 = num;
                    string shortWord = array[i];
                    Console.WriteLine("New shortest word is: \"{0}\" with a length of {1}", shortWord, num1);
                }

            }

            return num1;
        }

        //Splits the string into an array, establishes maxx as the max value possible of an int, foreach recorre the array, checks if the length of the value is less than the maxx, if it is
        // it changes the max value and returns it.
        /*
         * public static int FindShort(string s)
    {
                string[] strArr = s.Split(' ');
                int maxx = int.MaxValue;

                    foreach (string item in strArr)
                        {
                             if (item.Length < maxx)
                                {
                                      maxx = item.Length;
                                }
                            }
                            return maxx;
    }*/
    }
}
