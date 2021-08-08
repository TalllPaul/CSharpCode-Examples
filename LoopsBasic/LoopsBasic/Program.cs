using System;

namespace LoopsBasic
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //FOR
            //List of even numbers from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //a string is a sequence of characters, it's like a list so we can iterate it.
            var name = "John Smith";

            for(var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            
            //FOREACH
            foreach(var item in name)
            {
                Console.WriteLine(item);
            }

            var arr = new int[] { 1, 2, 3, 4 };

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            //WHILE

            int counter = 0;

            while(counter <= 10)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
               

                counter++;
            }

            //The loop will run forever asking the user to write their name until the string is empty or whitespace.
            while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(input))
                {
                    break;
                } else
                {
                    Console.WriteLine("@Echo: " + input);
                    //With a continue here it will go back and star the loop rather than reach trhe break after it.
                    continue;
                }

                //break;
            }
        }
    }
}
