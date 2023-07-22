using System;
namespace ThrowTest {
     class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Enter your age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                bool validAge = IsGreaterTha18(age);
                if (validAge) {
                    Console.WriteLine("you can vote in election.");
                }
                else {
                    Console.WriteLine("you can  not vote in election.");
                }
            }catch(Exception e) {
                Console.WriteLine("Oh!! sorry we only accept the number values :( ");
                Console.WriteLine("Error is cause of "+e.Message); 
            }
            Console.WriteLine("Press any key to close this window.");
            Console.ReadKey();
        }//end of main 

        static bool IsGreaterTha18(int age) {
            bool result = false;
            if (age <= 0) {
                throw new ArgumentException("Your age can not be negative value or equal 0 ");
            }
            else if (age > 18) {
                result=true;
            }
            return result;
        }
    }
}
