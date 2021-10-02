using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
{
    public interface ILogger
    {

        void Logerror(string message);
        void LogInfo(string message);

    }
}
