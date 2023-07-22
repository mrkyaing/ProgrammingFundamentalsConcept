using System;

namespace OOPTest2 {
    internal class Program {
        static void Main(string[] args) {
            Computer myPC = new Computer();
            myPC.CPU = "i5";
            myPC.RAM = "8GB";
            myPC.Specification();
            Console.WriteLine("=====================");
            Computer yourPC = new Computer();
            yourPC.Specification();
            Computer c = new Computer("i7", "16GB", "512GB", "2GB", "BusinessSuitePC", "Desktop", "Dell", 2000000);
            c.Specification();
            c.PowerOn();
            c.ReadDocument();
            c.UseCalculator();
            c.PowerOff();
            Console.WriteLine("=====================");
            Computer JamePC=new Computer("i3","4BG","256GB");
            JamePC.Specification();
            JamePC.DrawStar();
            JamePC.DrawStar(10);
            JamePC.DrawStar(10, '@');
            Console.WriteLine("=====================");

            Circle circle=new Circle();
            circle.radius = 10;//assign the value 
            circle.CalcualteArea();//3.14*10*10 
            Console.Write("radius of circle " + circle.radius);//10
            Console.WriteLine("PI value is " + Circle.PiValue);//3.14 
            Circle.CalcualteCircumference(10);
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }

        public void SayHello() {

        }
    }

   
}
