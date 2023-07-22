using System;
namespace OOPDay3 {
    internal class Calculator {
        public void Add(int n1,int n2) {
            int result=n1 + n2;
            Console.WriteLine($"Adding result is {result}");
        }
        //method overloading >> compile time polymoprhism
        public void Add(int n1, int n2,int n3) {
            int result = n1 + n2+n3;
            Console.WriteLine($"Adding result is {result}");
        }
        //method overloading >> compile time polymoprhism
        public void Add(double d1,double d2) {
            double result=d1 + d2;
            Console.WriteLine($"Adding result is {result}");
        }
        //Another Method 
        public void Sum(double d1, double d2) {
            double result = d1 + d2;
            Console.WriteLine($"Adding result is {result}");
        }
    }
}
