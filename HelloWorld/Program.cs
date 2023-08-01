using System;

namespace HelloWorld {
    public class Program {
        static void Main(string[] args) {
            Console.Write("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your current speed: ");
            int currentSpeed = Convert.ToInt32(Console.ReadLine());

            int demeritPoint = 0;

            if (currentSpeed <= speedLimit) {
                Console.WriteLine("OK");
            } else {
                int speedDifference = currentSpeed - speedLimit;
                for (int counter = 1; counter <= speedDifference; counter++) {
                    if (counter % 5 == 0) {
                        demeritPoint++;
                    }
                }
            }

            Console.WriteLine("Demerit points: {0}", demeritPoint);
            if (demeritPoint >= 12) {
                Console.WriteLine("License suspended!!!");
            }
        }
    }
}
