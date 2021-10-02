using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        //Saves the message to a file.
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void Logerror(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {

            //Using frees resources (auto Dispoe());
            using (var streamwriter = new StreamWriter(_path, true))
            {
                streamwriter.WriteLine(messageType + ": " +  message);
            }

        }
    }
}
