using System;

namespace OOPTest2 {
    public  class Circle {
        public static decimal PiValue=3.14m;
        public   int radius;
        public  void CalcualteArea() {
            decimal result=PiValue* radius*radius;
            Console.WriteLine("Area Of Circle is "+result);
        }

        public static void CalcualteCircumference(int radius) {
            decimal result = 2*PiValue  * radius;
            Console.WriteLine("Area Of Circle is " + result);
        }
    }
}
