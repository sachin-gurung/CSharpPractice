using System;
using System.Collections.Generic;
<<<<<<< HEAD
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
=======
using System.Linq;
using System.Net.Http.Headers;

namespace HelloWorld {
    public class Program {

        /*
         * Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */
        static void Main(string[] args) {
            var list = new List<int>();

            while (list.Count < 5) {
                Console.WriteLine("Type 5 unique numbers:");
                var input = Convert.ToInt32(Console.ReadLine());

                if (list.Contains(input))
                    Console.WriteLine("Error! Number already in list!");
                else
                    list.Add(input);
            }

            list.Sort();
            foreach (var number in list) {
                Console.Write("{0} ", number);
>>>>>>> 3fa8ca8cc7b67ee9095b03e3efff5a200b863632
            }
        }
    }
}
