using System;


namespace MultiArrayApp2 {
     class Program {
        static void Main(string[] args) {
            string[,] marks = new string[5, 7];
            marks[0, 0] = "Student Name";
            marks[0, 1] = "Myanmar";
            marks[0, 2] = "English";
            marks[0, 3] = "Bio";
            marks[0, 4] = "Chemistry";
            marks[0, 5] = "Physics";
            marks[0, 6] = "Math";

            marks[1, 0] = "SU SU";
            marks[2, 0] = "MG MG";
            marks[3, 0] = "MIN MIN";
            marks[4, 0] = "AUNG AUNG";

            //writing data into array 
            Random rdm = new Random();
            for (int i = 1; i < 5;i++) {
                for (int j = 1; j < 7; j++) {
                    marks[i, j] = Convert.ToString(rdm.Next()).Substring(0,2);
                }
            }
            //reading data from array 
            for (int i = 0; i < 5;i++) {
                for (int j = 0; j < 7; j++) {
                    Console.Write(marks[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
