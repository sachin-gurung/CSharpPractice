﻿namespace HelloWorld
{
    public partial class Program
    {
        public class DbMigrator
        {
            private readonly Logger _logger;

            public DbMigrator(Logger logger)
            {
                _logger = logger;
            }

            public void Migrate()
            {
                _logger.log("We are migrating blah blah blah...");
            }
        }
    }
}