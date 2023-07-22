using System;

namespace OOPTest3 {
    internal class BankAccount {
        
        private string accountname;
        public string AccountName
        {
            get { return accountname; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("invalid account name ");
                }
                accountname = value;
            }
        }
        private string accountno;
       
        public string AccountNo
        {
            get { return accountno; }
            set {
                if(string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("invalid account no ");
                }
                else if (Convert.ToInt32(accountno) < 0) {
                    throw new ArgumentException("invalid account no.");
                }
                accountno = value; 
            }
        }

        private decimal openingbalance;
        public decimal OpeningBalance
        {
            get { return openingbalance; }
            set
            {
                if (value < 1000) {
                    throw new ArgumentException("mininum opening balance amunt must be greater than 1000 mmk");
                }
                openingbalance = value;
            }
        }
        public void Deposite(decimal amount) {
            openingbalance+= amount;
            Console.WriteLine("deposite successfully");
            ShowCurrentBalance();
        }
        public void Withdraw(decimal amount) {
            if (amount > (openingbalance-1000)) {
                throw new ArgumentException("your balance do not enough to withdraw");
            }
            openingbalance-=amount;
            Console.WriteLine("withdraw successfully");
            ShowCurrentBalance();
        }
        //encapsulation method 
        private void ShowCurrentBalance() {
            Console.WriteLine("Current balance is " + openingbalance);
        }
        public void DisplayInfo() {
            Console.WriteLine("account name " + accountname);
            Console.WriteLine("account no " + accountno);
            Console.WriteLine("account balance " + openingbalance);
        }
    }
}
