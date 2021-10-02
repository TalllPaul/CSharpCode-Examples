using System;
using System.Collections.Generic;
using System.Text;

//Migrates imaginary database
//Create an object of the Logger class and call the Logger method sending the string. 

namespace Composition
{
    public class DBMigrator
    {
        private readonly Logger _logger;
        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating...");
        }
    }
}
