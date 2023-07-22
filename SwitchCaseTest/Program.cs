using System;


namespace SwitchCaseTest {
     class Program {
        static void Main(string[] args) {
            Console.Write("Type Month Number (1 to 12)");
           string inputValue=Console.ReadLine();
            switch(inputValue) {
                case "1":Console.WriteLine("It is January Month"); break;
                case "2": Console.WriteLine("It is Febary Month"); break;
                case "3": Console.WriteLine("It is March Month"); break;
                case "4": Console.WriteLine("It is April Month"); break;
                case "5": Console.WriteLine("It is May Month"); break;
                case "6": Console.WriteLine("It is June Month"); break;
                case "7": Console.WriteLine("It is July Month"); break;
                case "8": Console.WriteLine("It is August Month"); break;
                case "9": Console.WriteLine("It is Septemter Month"); break;
                case "10": Console.WriteLine("It is October Month"); break;
                case "11": Console.WriteLine("It is November Month"); break;
                case "12": Console.WriteLine("It is December Month"); break;
                default: Console.WriteLine("Invalid Input .Try again");break;
            }
            Console.WriteLine("press any to exist");
            Console.ReadKey();
        }
    }
}
