using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {

            int sum = 0;

            while (true) {

                Console.Write("Enter a number or \"ok\" to exit:");
                var input = Console.ReadLine();

                if (input == "ok") {
                    break;
                }

                var number = Convert.ToInt32(input);
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
