using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
{
    public class ConsoleLogger : ILogger
    {
        public void Logerror(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
