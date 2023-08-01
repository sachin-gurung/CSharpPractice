using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            string sentence = "My name is Sachin Gurung.";

            foreach (var letter in sentence) {
                Console.Write(letter);
            }
        }
    }
}
