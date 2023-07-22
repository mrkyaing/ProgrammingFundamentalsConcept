using System;


namespace MethodTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello");
            SayHello();//method call/invoctaion 
            PrintStar(10, 'x');//method call/invoctaion 
            PrintStar(5, '@');
            SayHello();//method call/invoctaion 
            decimal totalcost = 155.805m;
            decimal taxAmount = TaxCalcualte(totalcost, 2);//1400
            decimal totalCostIncludeTax = taxAmount + totalcost;
            Console.WriteLine("Total Cost Include Tax:" + totalCostIncludeTax);
            int result = Sum(200, 300, 500);
            Console.WriteLine("result " + result);
            Console.WriteLine("press any to clsoe this window");
            Console.ReadKey();
        }
        //key elements 5 items when you define a method
        //define a method SayHello with No paremeter
        static void SayHello() {
            Console.WriteLine("Hi,i am from say hello");
        }
        static void PrintStar(int count, char format) {
            for (int i = 1; i <= count; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write(format);
                }
                Console.WriteLine();
            }
        }

        static decimal TaxCalcualte(decimal totalcost, decimal taxPercetance) {//2
            Console.WriteLine("Total cost:" + totalcost);//70000
            decimal taxAmount = taxPercetance / Convert.ToDecimal(100) * totalcost;
            Console.WriteLine("Tax :" + taxAmount);//1400
            return taxAmount;
        }

        static int Sum(int n1, int n2, int n3) {
            int result = n1 + n2 + n3;
            return result;
        }
    }
}
