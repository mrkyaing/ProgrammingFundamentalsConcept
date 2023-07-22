using System;

namespace OOPDay4 {
    public class BankOperation : IBankOperation {

        BankAccount account;
        
        //Constuctor accept the BankAccount Object here 
        public BankOperation(BankAccount bankAccount) {
            account = bankAccount;//create object for BankAccount
        }
        public void CheckBalance(string userName, string password) {
           if(userName.Equals("admin") && password.Equals("admin")) {
                Console.WriteLine($"Your Balance is {account.Balance}");}
        }

        public void Deposit(decimal amount) {
            account.Balance += amount;
            Console.WriteLine("Deposite successfully");
        }

        public void Transfer(string fromAccountNo, string toAccountNo, double Amount) {
            if (toAccountNo.Equals(account.AccountNo)) {
                account.Balance +=Convert.ToDecimal(Amount);
                Console.WriteLine("Transfer successfully");
                Console.WriteLine($"transfering  from {fromAccountNo} to {toAccountNo} with the amout {Amount}");
            }
        }

        public void Withdraw(decimal amount) {//5000
            if (account.Balance > amount) {
                account.Balance -= amount;
                Console.WriteLine("Withdraw successfully");
            }else {
                Console.WriteLine($"Amount is not enough .your current balance is {account.Balance}");
            }
        }
    }
}
