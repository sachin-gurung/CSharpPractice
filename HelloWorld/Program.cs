using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append("New line").AppendLine().Append("Another new line").Replace("N", "n");

            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
