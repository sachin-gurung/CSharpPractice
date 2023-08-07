using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            /*Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.
             */

            var uniqueList = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or type \"Quit\" to exit: ");
                var input = Console.ReadLine();

                if (input.CompareTo("quit") == 0)
                {
                    break;
                }
                else
                {
                    var number = Convert.ToInt32(input);
                    if (uniqueList.Contains(number))
                    {
                        continue;
                    }
                    else
                    {
                        uniqueList.Add(number);
                    }
                }
            }

            foreach (var uniqueNum in uniqueList) {
                Console.WriteLine("{0}", uniqueNum);
            }
        }
    }
}
