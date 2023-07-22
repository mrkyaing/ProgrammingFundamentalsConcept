using System;


namespace MethodTest2 {
     class Program {
        //Main Method
        static void Main(string[] args) {
            Console.WriteLine("program stat");
            DrawPattern(5,'X');//Method invocation
            DrawPattern(10, '*');
            Console.WriteLine("Program finished");
            decimal totalCost = 200000;
            Console.WriteLine($"total cost {totalCost}");//200000

            decimal taxResult = TaxCalculate(totalCost, 2);
            Console.WriteLine($"tax amout is {taxResult}");//4000

            decimal totalCostIncludeTax = taxResult + totalCost;
            Console.WriteLine($"total cost include tax {totalCostIncludeTax}");//204000
            
            int sumResult=Sum2Numbers(550, 550);
            Console.WriteLine($"The sum result of 2 number is {sumResult}");
            int resultOfCube=Cube(3);
            Console.WriteLine($"Result Of 3 Cube :{resultOfCube}");
            Console.WriteLine("pres any key to exists");
            Console.ReadKey();
        }

        //Method Defination 
      static  void DrawPattern(int count,char format) {
            for(int i=1;i<=count;i++) {
                for(int j=1;j<=i;j++) {
                    Console.Write(format);
                }
                Console.WriteLine();
            }
        }
        //define a method  TaxCalculate with 2 parameters/arguemtns 
        static decimal TaxCalculate(decimal totalCost,int taxPercetance) {
            decimal taxAmount = taxPercetance * totalCost/100;
            return taxAmount;
        }
        static int Sum2Numbers(int n1,int n2) {
            return n1 + n2;
        }
        static int Cube(int n) {
            int result = n * n * n;
            return result;
        }
    }
}
