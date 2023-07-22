using System;


namespace GuessGame {
     class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Guess Game (0 to 20) started");
                Console.Write("Guess my number : ");
                int inputValue = Convert.ToInt32(Console.ReadLine());// 12 ,10 ,19 , a , hello @ ,# 

                Random random = new Random();
                int hiddenvalue = random.Next(20);

                bool isNext = true;
                while (isNext) {
                    if (inputValue == hiddenvalue) {
                        Console.WriteLine("Wow, You got it right.");
                        Console.WriteLine("Game End");
                        isNext = false;
                        break;
                    }
                    else {
                        Console.WriteLine("No, You got it wrong");
                        Console.Write("Guess again");
                        inputValue = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            catch (FormatException e) {
                Console.WriteLine("Oh!! sorry , we only accept number values ");
            }
            catch (ArithmeticException e) {
                Console.WriteLine("Oh!! sorry , we only accept number values ");
            }
            catch (Exception e) {
                Console.WriteLine("Oh!! sorry , we only accept number values ");
            }
            Console.WriteLine("Press any key to close this window");
            Console.ReadKey();
        }
    }
}
