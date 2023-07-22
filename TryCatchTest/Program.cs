using System;


namespace TryCatchTest {
     class Program {
        static void Main(string[] args) {
            try {
                int[] marks = new int[10];
                marks[0] = 1;
                marks[10] = 2;
            }catch(Exception e) {
                Console.WriteLine("Error occur because of invalid index value ");
            }
            Console.WriteLine("press any key to close ");
            Console.ReadKey();
        }
    }
}
