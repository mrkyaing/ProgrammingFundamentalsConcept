using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace StackDemo {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Stack Demo :Last In First Out");
                Stack<int> stack = new Stack<int>();//Generic Type (int)
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                Console.WriteLine(stack.Pop());//4
                Console.WriteLine(stack.Pop());//3
                Console.WriteLine(stack.Pop());//2
                Console.WriteLine(stack.Pop());//1
               // Console.WriteLine(stack.Pop());// Stack Is Empty 
                stack.Push(200);
                Console.WriteLine(stack.Peek());//200
                //Console.WriteLine(stack.Pop());//Stack Empty
                Stack<string> msg = new Stack<string>();//Generic Type (string)
                msg.Push("hi");
                msg.Push("Hello");
                msg.Push("how are you");
                int count = msg.Count();//3
              for(int i = 0; i < count; i++) {
                    Console.WriteLine(msg.Pop());
                }
                
                Stack anyData = new Stack();//Non-Generic Stack Type 
                anyData.Push("Hello");
                anyData.Push(1);
                anyData.Push(2);
                anyData.Push('A');
                anyData.Push(20.3);
                int c = anyData.Count;//5
                for (int i = 0; i < c; i++) {
                    Console.WriteLine(anyData.Pop());
                }

                Console.WriteLine("Queue Demo :First In First Out");
               
                Queue ticketBuy = new Queue();
                ticketBuy.Enqueue("ticket 1");
                ticketBuy.Enqueue("ticket 2");
                ticketBuy.Enqueue(1000);
               int qc=ticketBuy.Count;
                for(int i=0;i < qc; i++) {
                    Console.WriteLine(ticketBuy.Dequeue());//ticket 1 
                }

                Queue<int> shippingItems=new Queue<int>();
                shippingItems.Enqueue(100);
                shippingItems.Enqueue(200);
                Console.WriteLine(shippingItems.Dequeue());//100
                Console.WriteLine(shippingItems.Dequeue());//200
                Console.WriteLine("IList ,List Demo");
                
                List<int> items=new List<int>();
                items.Add(100);
                items.Add(200);
                items.Add(300);
                items.RemoveAt(2);//remove 100 

                for(int i=0;i < items.Count;i++) {
                   Console.WriteLine( items[i]);//100 
                }
                IList<int> items2=new List<int>();
                items2.Add(100);
                items2.Add(200);
                items2.Add(300);
                items2.Add(400);
                for (int i = 3; i < items2.Count; i-) {
                    Console.WriteLine(items2[i]);//100 
                }
                Console.WriteLine("press any key to close this window");
                Console.ReadKey();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            int[] marks = new int[10];// 0 to 9
        }
    }
}
