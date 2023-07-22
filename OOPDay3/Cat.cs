using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3 {
    internal class Cat :Animal{
        public void Climb() {
            Console.WriteLine($"{Name} is climbing to the tree");
        }
        public override void Speak() {
            Console.WriteLine("Meow..Meow.Meow");
        }
    }
}
