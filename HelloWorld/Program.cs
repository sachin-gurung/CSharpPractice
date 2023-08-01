using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            int count = 0;
            int minValue = 1;
            int maxValue = 100;

            for (int i = 0; i < maxValue; i++) {
                if (i % 3 == 0) {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
