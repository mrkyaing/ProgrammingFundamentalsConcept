using System;

namespace ElectionApp {
     class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
               
                bool ValidAge = IsValidAage(name,age);
                 if (ValidAge) {
                    Console.WriteLine(name + ", you can vote in election.");
                }
                else {
                    Console.WriteLine(name + ", you can't vote in election.");
                }
            }catch(ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("oh!! sorry ,we only accept the numer values");
                PlayBeep(3);
            }
            Console.WriteLine("Thanks You!!!!");
            Console.WriteLine("Press any key to close this window!!");
            Console.ReadKey();
        }

        static void PlayBeep(int count) {
            for(int i=1;i<=count;i++) {
                Console.Beep();
            }
        }
        static bool IsValidAage(string name,int age) {
            bool result=false;
            if(string.IsNullOrEmpty(name)) {
                throw new ArgumentException("Name is required");
            } 
           else  if (age <= 0) {
                throw new ArgumentException("Oh!,sorry your name must be postive number values");
            }
            else if ( age>=18)
            {
                result = true;
            }
            return result;
        }
        
      
    }
}
