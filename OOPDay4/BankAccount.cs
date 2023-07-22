using System;
namespace OOPDay4 {
    public class BankAccount {
        public string AccountNo, AccountName, AccountType;
        public DateTime OpeningDate;
        public decimal Balance;
        public void DisplayInfo() {
            Console.WriteLine($"Account No: {AccountNo}");
            Console.WriteLine($"Account type: {AccountType}");
            Console.WriteLine($"Account Name: {AccountName}");
            Console.WriteLine($"Account Opening Date: {OpeningDate}");
            Console.WriteLine($"Account Balance: {Balance}");
        }
    }
}
