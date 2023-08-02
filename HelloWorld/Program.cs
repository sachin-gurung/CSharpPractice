using System;
using System.Collections.Generic;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            var numbers = new List<int>() { 1, 2, 3 };
            numbers.Add(4);    //Add
            numbers.AddRange(new int[3] { 5, 6, 7 });    //AddRange
            foreach (var i in numbers) {
                Console.WriteLine(i);
            }

            Console.WriteLine("Index of 2: " + numbers.IndexOf(3));  //IndexOf
            Console.WriteLine("Last Index of 2: " + numbers.LastIndexOf(3));  //LastIndexOf

            Console.WriteLine("Count: " + numbers.Count); //Count
            numbers.Remove(1);    //Remove
            foreach (var i in numbers) {
                Console.WriteLine("After removing: " + i);
            }

            numbers.Clear();
            Console.WriteLine("Total count after clear(): " + numbers.Count);
        }
    }
}
