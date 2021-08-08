using System;
using System.Collections.Generic;
using System.Text;

namespace ResumingTextStringProgram
{
    public class StringUtility
    {
        const int maxLength = 25;
        public static string SummarizeText(string text)
        {


            //Check if length is below a given threshold, if it is, we just display it, if not we summarise it.

            if (text.Length < maxLength)
            {
                return text;

            }

            //The not so good way of summarising it, doing it this way could lose a word.
            //var summarised = text.Substring(0, maxLength);
            //Console.WriteLine(summarised);

            //Count number of words that roughly fits into 20 characters
            //Split each word, returns a string array
            var words = text.Split(' ');
            var totalCharacters = 0;

            //A List to hold each word
            var summaryWords = new List<string>();

            //Loop the string array adding each word into the List of summarised words 
            foreach (var word in words)
            {
                summaryWords.Add(word);

                //totalCharacters += length of the word +1 for the space.
                totalCharacters += word.Length + 1;

                //Checks if the characters of the words is more than the max length, if it is, the loop breaks.
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }

            //Here we join each word with a space and then print it out.     
            return String.Join(" ", summaryWords) + "...";
        }
    }
}

