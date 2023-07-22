using System;


namespace MultiArrayApp {
     class Program {
        static void Main(string[] args) {
            int[] marks = new int[10];
            
            //writing data into array 
            for(int i = 0; i < 10; i++) {
                marks[i] = 10;
            }

            //Reading data from array 
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("result of multi-dimensional test.");
            int[,] populations =new int[5, 5];
            populations[0,0] = 200;
            populations[2, 4] = 700;
            populations[3, 2] = 100;
            
            Console.WriteLine(populations[0,0]);//200
            Console.WriteLine(populations[2, 4]);//700
            Console.WriteLine(populations[3, 2]);//100
            Console.WriteLine(populations[2, 2]);//0

            int[,] data = new int[3, 5];
            
            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 5; j++) {
                    data[i, j] = 101;
                }
            }


            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write(data[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("press any key to close window");
            Console.ReadKey();
        }
    }
}
