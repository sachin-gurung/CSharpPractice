using System;
using System.Collections.Generic;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            var nameList = new List<string>();
            while (true) {
                Console.Write("Enter user name: ");
                var name = Console.ReadLine();
                nameList.Add(name);
                
                if (String.IsNullOrWhiteSpace(name)) {
                    break;
                }
            }

            if (nameList.Count == 0) {
                Console.WriteLine("Nobody likes your post");
            } else if (nameList.Count == 1) {
                Console.WriteLine("{0} likes your post", nameList[0]);
            } else if (nameList.Count == 2) {
                Console.WriteLine("{0} and {1} like your post", nameList[0], nameList[1]);
            } else {
                Console.WriteLine("{0}, {1} and others like your post", nameList[0], nameList[1]);
            }

            //The code below is just to test if it's saving all the names in the list
            Console.WriteLine("List of names are below:");
            nameList.ForEach(name => Console.WriteLine(name));
        }
    }
}
