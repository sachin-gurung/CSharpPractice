using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            int evenNumber;
            for (int i = 0; i <= 10; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine("{0} is even number", i);
                }
                i++;
            }
        }
    }
}
