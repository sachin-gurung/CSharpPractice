using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Write("Type your name here: ");
                var name = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(name)) {
                    break;
                }
            }
        }
    }
}
