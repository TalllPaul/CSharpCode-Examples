using System;

namespace GuessRandomNumber
{
    /*
     * Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
     * If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is b
     * behaving correctly, you can display the secret number on the console first.)
     * */
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            int num = rand.Next(1, 10);

            int guessCounter = 1;
            Console.WriteLine("Secret number: " + num);

            while(guessCounter <= 4)
            {

                Console.WriteLine("Enter a number between 1 and 10: ");
                int input = Convert.ToInt32(Console.ReadLine());
                guessCounter++;

                if(input == num)
                {
                    Console.WriteLine("You won");
                    break;
                }
                
            }

            if (guessCounter > 4)
            {
                Console.WriteLine("You lost");
            }

        }
    }
}
