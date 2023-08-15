using System;

namespace HelloWorld {
    public partial class Program {
        static void Main(string[] args) {
            var dbMigrator = new DbMigrator(new Logger());
            var installer = new Installer(new Logger());

            dbMigrator.Migrate();
            installer.Install();
            Console.ReadLine();
            }
        }
    }


