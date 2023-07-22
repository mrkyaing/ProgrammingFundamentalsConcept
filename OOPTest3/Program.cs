using System;

namespace OOPTest3 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Person p1 = new Person();
                p1.SetName("Mg Mg");
                p1.SetEmail("mgmg@gmail.com");
                p1.SetAge(30);
                p1.SetAddress("YGN");
                p1.About();
                Console.WriteLine("=============");
                Person p2 = new Person();
                p1.SetName("su su");
                p1.SetEmail("susu@gmail.com");
                p1.SetAge(20);
                p1.SetAddress("MDY");
                p2.About();

                BankAccount myAccount=new BankAccount();
                myAccount.AccountName = "MinMin";
                myAccount.AccountNo = "001122";
                myAccount.OpeningBalance = 2000;
                myAccount.Deposite(3000);//5000
                myAccount.DisplayInfo();
                myAccount.Withdraw(1500);//3500
                myAccount.DisplayInfo();
                myAccount.Withdraw(2500);
                myAccount.Deposite(2500);
                myAccount.Deposite(1500);

                BankAccount yourAccount = new BankAccount();
                yourAccount.AccountName = "";
                yourAccount.AccountNo = "-635";
                yourAccount.OpeningBalance = 100;
                yourAccount.Deposite(3000);//5000
                yourAccount.DisplayInfo();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
