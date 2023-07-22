using System;
using System.Security.Policy;
using System.Web;

namespace OOPTest2 {
class Computer {
        //Members/States of Computer class 
        public   string CPU, RAM, Storage, GPU, Model, Type,Brand;
        public decimal UnitPrice;
       //Default Constructor 
        public Computer() {
            CPU = "not define";
            RAM = "not define";
            Storage = "not define";
            GPU = "not define";
            Model= "not define";
            Type = "not define";
            Brand = "not define";
            UnitPrice = 0;
        }
        //Paremeter Constructor 
        public Computer(string cpu,string ram,string storage,string gpu,string model,string type,string brand,decimal unitPrice) {
            CPU = cpu;
            RAM = ram;
            Storage = storage;
            GPU = gpu;
            Model = model;
            Type = type;
            Brand = brand;
            UnitPrice = unitPrice;
        }
        public Computer(string cpu,string ram,string storage) {
            this.CPU = cpu;
            this.RAM = ram;
            this.Storage = storage;
        }
        public void ReadDocument() {
            Console.WriteLine("Reading a doc");
        }
        public void PowerOn() {
            Console.WriteLine("Start the PC");
        }
        public void PowerOff() {
            Console.WriteLine("Shutdown the PC");
        }
        public void UseCalculator() {
            Console.WriteLine("Calculator is opened.");
        }
        public void DrawStar() {
            Console.WriteLine("*");
        }
        public void DrawStar(int count) {
            for(int i=1;i<=count;i++) {
                Console.WriteLine("*");
            }
        }
        public void DrawStar(int count,char format) {
            for (int i = 1; i <= count; i++) {
                Console.WriteLine(format);
            }
        }
        public void Specification() {
            Console.WriteLine("Computer Specification");
            Console.WriteLine($"CPU :{CPU}");
            Console.WriteLine($"RAM :{RAM}");
            Console.WriteLine($"Storage :{Storage}");
            Console.WriteLine($"Model :{Model}");
            Console.WriteLine($"Type :{Type}");
            Console.WriteLine($"UnitPrice :{UnitPrice}");
            Console.WriteLine($"GPU :{GPU}");
            Console.WriteLine($"Brand :{Brand}");
        }
    }
}
