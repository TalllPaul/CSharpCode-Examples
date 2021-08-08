using System;
using System.Collections.Generic;

namespace FacebookLikesProgram
{
    /*
     *  When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        - If no one likes your post, it doesn't display anything.
        - If only one person likes your post, it displays: [Friend's Name] likes your post.
        - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

        Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
        Depending on the number of names provided, display a message based on the above pattern.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//FACEBOOK LIKES\\\\");


            //Declare list to store the names introduced.
            var nombres = new List<string>();

            while(true)
            {
                //Console input and store into the variable input, add to the List.
                Console.WriteLine("Enter different names: ");
                var input = Console.ReadLine();

                //Check if the input value is empty (user hits Enter with no values introduced).
                if (string.IsNullOrEmpty(input))
                {
                    //Break out of loop
                    break;
                }

                nombres.Add(input);

            }

            //Conditions for the console output. 
            if (nombres.Count == 1)
                {
                    Console.WriteLine("{0} likes your post.", nombres[0]);
                } else if(nombres.Count == 2)
                {
                    Console.WriteLine("{0} and {1} like your post.", nombres[0], nombres[1]);
                } else if(nombres.Count > 2)
                {
                    Console.WriteLine("{0}, {1} and {2} others like your post.", nombres[0], nombres[1], (nombres.Count - 2));
                }

            
            
        }
    }
}
