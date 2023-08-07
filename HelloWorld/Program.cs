using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace HelloWorld {
    public class Program {
        /*
         * Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */
        static void Main(string[] args)
        {
            var name = "Sachin Gurung ";
            var trimmedName = name.Trim();
            Console.WriteLine("'"+trimmedName+"'");
            Console.WriteLine(trimmedName.ToUpper());
            var names = name.Split(' ');
            foreach (var i in names)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
