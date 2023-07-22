using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo2 {
     class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("type array size");
            int length=Convert.ToInt32(Console.ReadLine()); //5
           
            int[] marks=new int[length];// 
           
            //Writing data to the array 
            for(int i=0;i < length; i++) {
                Console.WriteLine("Enter value "+(i+1)+" : ");
                int inputMark =Convert.ToInt32( Console.ReadLine());
                marks[i] = inputMark;
            }

            //printing out data from the array 
            Console.WriteLine("your input value are :");
            for(int j = 0; j < length; j++) {
                Console.WriteLine(marks[j]);
            }

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
