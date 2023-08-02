using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            int number;
            int result = 1;
            Console.Write("Enter a number: ");
            number = Convert.ToByte(Console.ReadLine());

            for (int i = number; i > 0; i--) {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
