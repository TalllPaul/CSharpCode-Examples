using System;
using System.Collections.Generic;

namespace ResumingTextStringProgram
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Summarising Text");

            var text = "This is going to be a really really really really really really long text";

            var summary = StringUtility.SummarizeText(text);
            Console.WriteLine(summary);
        }

    }
}
