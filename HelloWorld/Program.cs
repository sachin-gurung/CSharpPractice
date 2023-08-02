using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld {
    public class Program {

        /*
         * Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
         */
        static void Main(string[] args) {
            Console.Write("Enter a series of numbers separated by comma: ");
            var input = Console.ReadLine();
            var numbers = GetListFromValuesSeparatedWithCommas(input);
            var maxNumber = numbers?.Max();
            Console.WriteLine(maxNumber);
        }

        private static IEnumerable<int> GetListFromValuesSeparatedWithCommas(string input) {
            return input?.Split(',').Select(number => Convert.ToInt32(number.Trim())).ToList();
        }
    }
}
