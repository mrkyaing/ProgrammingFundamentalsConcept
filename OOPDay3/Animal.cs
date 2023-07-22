using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3 {
    internal class Animal {
       
        public string Name;
        public int LifeSpan;
        public string Color;
        public int Height;
        public int Weight;
        public void Eat() {
            Console.WriteLine($"{Name} is eating");//string interpolation approach 
          //  Console.WriteLine(Name + " is eating");// + contancation approach 
        }
        public void Sleep() {
            Console.WriteLine($"{Name} is sleeping");
        }
        //Method Override >> runtime polymorphism 
        public virtual void Speak() {
            Console.WriteLine($"{Name} is talking");
        }
        public void DisplayInfo() {
            Console.WriteLine("Name is " + Name);
            Console.WriteLine("Color is " + Color);
            Console.WriteLine($"LifeSpan is {LifeSpan}");
            Console.WriteLine($"Height is {Height}");
            Console.WriteLine($"Weight is {Weight}");
        }
    }
}
