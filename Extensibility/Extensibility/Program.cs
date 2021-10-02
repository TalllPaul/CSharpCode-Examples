using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DBMigrator(new ConsoleLogger());
            var dbMigrator = new DBMigrator(new FileLogger(@"path"));
            dbMigrator.Migrate();

        }
    }
}
