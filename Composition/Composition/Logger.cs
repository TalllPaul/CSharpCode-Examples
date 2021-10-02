using System;
using System.Collections.Generic;
using System.Text;

//This is the class that has all of the common functionality (like a parent).

namespace Composition
{
    public class Logger
    {

        public void Log(string message)
        {
            Console.WriteLine(message);
        }


    }
}
