using System;

namespace AlgorithmPractice {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter number 1:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            
            if (n1 > n2) {
                max = n1;
            }
            else {
                max= n2;
            }

            if(max>n3) {
                Console.WriteLine($"The most largest value between those three numbers {n1},{n2},{n3} is {max}");
            }
            else { Console.WriteLine($"The most largest value between those three numbers {n1},{n2},{n3} is {n3}"); }

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
