using System;
using System.Security.Cryptography;

namespace ShoppingCostApp {
     class Program {
        static void Main(string[] args) {
            try {

                Console.Write("How many items do you want to buy?");
                int buyCount = Convert.ToInt32(Console.ReadLine());//50, A 
                int[] items = new int[buyCount];
                //writing data to array 
                for (int i = 0; i < buyCount; i++) {
                    Console.Write("Enter Items " + (i + 1) + ":");
                    items[i] = Convert.ToInt32(Console.ReadLine());
                }
                int total = 0;
                decimal avg = 0;
                //printout data from array 
                Console.WriteLine("Your buying items are :");
                for (int i = 0; i < buyCount; i++) {
                    Console.Write(items[i] + ",");//500,1000,550
                    total += items[i];
                }
                Console.WriteLine();//new Line
                Console.WriteLine("Total Cost :" + total);
                avg = Convert.ToDecimal(total) / Convert.ToDecimal(buyCount);
                Console.WriteLine("Average Cost:" + avg);
                Array.Sort(items);//sorting the array with ascending order 
                Console.WriteLine("Mininum Cost:" + items[0]);
                Console.WriteLine("Maximun Cost:" + items[buyCount - 1]);
            }catch(Exception e) {
                Console.WriteLine("Oh!! sorry we only accept numbers :( ");
            }
            Console.WriteLine("press any key to clsoe.");
            Console.ReadKey();
        }
    }
}
