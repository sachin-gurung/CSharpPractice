using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args)
        {
            /*
             * Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
             */
            Console.WriteLine("Enter a few numbers separated by hyphen (eg 1-3-4-5): ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();
            var isDuplicate = false;
            var uniques = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
                else
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                Console.WriteLine("Duplicates!");
                Console.ReadLine();
            }
        }
    }
}
