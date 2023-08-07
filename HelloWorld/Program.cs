using System;
using System.Collections.Generic;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
			/*
             * Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
             */
			var list = new List<int>();
            while (true) {
                Console.WriteLine("Type a list of number, separated by commas");
                var input = Console.ReadLine();

                var array = input.Split(',');

                if ((array.Length == 0) || (array.Length < 5)) {
                    Console.WriteLine("Invalid list! Try again.");
                } else {
                    foreach (var number in array)
                        list.Add(Convert.ToInt32(number));
                    break;
                }
            }
            list.Sort();

            for (int i = 0; i < 3; i++)
                Console.Write("{0} ", list[i]);
        }
    }
}
