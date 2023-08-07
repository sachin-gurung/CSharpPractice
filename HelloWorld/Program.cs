using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace HelloWorld {
    public class Program {
        /*
         * Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */
        static void Main(string[] args) {
			var list = new List<int>();
            while (true)
            {
                Console.WriteLine("Type a list of number, separated by commas");
                var input = Console.ReadLine();

                var array = input.Split(',');

                if ((array.Length == 0) || (array.Length < 5))
                {
                    Console.WriteLine("Invalid list! Try again.");
                }
                else
                {
                    foreach (var number in array)
                        list.Add(Convert.ToInt32(number));
                    break;
                }

                list.Sort();

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("{0} ", list[i]);
                }
            }

        }
    }
}
