using System;


namespace FIndVowelConstant {
     class Program {
        static void Main(string[] args) {
            Console.Write("Enter a sentece :");
            string words=Console.ReadLine();//Hello I am . today is Sunday 

            words=words.ToLower();//hello i am  today is sunday 
            
            int vowelCount = 0;
            int constantCount = 0;
           
            for(int i = 0; i < words.Length;i++) {
                if (words[i] == 'a' || words[i] == 'e' || words[i] == 'i' || words[i] == 'o'|| words[i] == 'u') {
                    vowelCount++;//2
                }else if (words[i]>='a' && words[i]<='z') {
                    constantCount++;//3
                }
            }
            Console.WriteLine("Total Vowel :" + vowelCount);
            Console.WriteLine("Total Consonant :" + constantCount);
            Console.WriteLine("press any key to exists");
            Console.ReadKey();
        }
    }
}
