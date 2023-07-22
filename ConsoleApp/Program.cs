using System;


namespace ConsoleApp {
     class Program {
        static void Main(string[] args) {
            int[] marks = new int[10];//declare the array with size or length 10 (it will start index 0 to 9) 
            string[] messages=new string[10];
            double[] shopping=new double[10];
            shopping[0] = 22.6;
            marks[0] = 100;//write data into array 
            marks[8] = 600;
            //marks[10] = 10;// array index out of bound error 
            //Console.WriteLine(marks[10]);// array index out of bound error  
            messages[0] = "Hi";
            messages[1] = "How are you?";
           
            int a = 10;
            Console.WriteLine(a);//10
           
            for(int i = 0; i < 10; i++) {
                Console.Write(marks[i]+" ");//100 0 0 0 0 0 0 0 600 0   read data from the array 
            }

            Console.WriteLine();
            for(int j = 0; j < 10; j++) {
                Console.WriteLine(messages[j]);//Hi           
                                                               //How are you?
                                                               //Empty Space
                                                               //Empty Space
            }

            int[] data = { 10,20,90,74,55,33,55,99,100};// size of array 6
           
            for(int i = 0; i < data.Length; i++) {
                Console.Write(data[i]+" ");// 10 20 
            }
            
            string[] storages = { "1GB", "2GB", "3GB", "4GB", "9GB", };//
            //to know array size array Name .Length
            for (int i = 0; i <storages.Length ; i++) {
                Console.WriteLine(storages[i]);
            }

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
