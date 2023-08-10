using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args)
        {
            //Constructors
            var cat1 = new Animal();
            var cat2 = new Animal("Mike");
            var cat3 = new Animal("Salli", true,20);
            Console.ReadLine();
        }
    }
}
