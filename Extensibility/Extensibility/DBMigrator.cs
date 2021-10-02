using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
    //Maybe instead of displaying messages on the console about the migration, further down the line we want to store in messages in a file, so instead of changing all the code we can use
    //interfaces to make it extensible.
{
    public class DBMigrator
    {
        //Dependancy injection, in the constructor we are specifying the dependencies for the DBMigrator class. In the main method we specify a concrete class to implement it. The class
        //that implements the ILogger interface is ConsoleLogger
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }
       public void Migrate()
        {
            //Instead of displaying the messages directly in the console we will use an interface logger.
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);
            //Console.WriteLine("Migration started at {0}", DateTime.Now);
            //Details of the migrating the database
            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
            //Console.WriteLine("Migration finished {1}", DateTime.Now);
            

        }


    }
}
