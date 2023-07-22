using System;

namespace OOPDay3 {
    internal class Dog:Animal {
        public void GuardHouse() {
            Console.WriteLine($"{Name} is guarding my house as security person");
        }

        public override void Speak() {
           // base.Speak();
            Console.WriteLine("Woak.Woak.Woak");
        }
    }
}
