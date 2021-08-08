using System;

namespace ReturnPascalCaseOfInputProgram
{
    class Program
    {
        /*
         * Write a program and ask the user to enter a few words separated by a space. 
         * Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", 
         * display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", 
         * the program should still display "NumberOfStudents".
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by spaces: ");
            var input = Console.ReadLine();

            //Separa las palabras por espacios y las guardan en un String array
            var splitUp = input.Split(" ");

            string variableName = "";

            //Recorre el array
           foreach(var item in splitUp)
            {
                //Makes the first letter of item an uppercase, then concatenates the rest of the word using substring from the second value (index 1) making sure it is all in lowercase.
                string wordWithPascalCase = char.ToUpper(item[0]) + item.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);

        }
    }
}
