namespace OOPDay4 {
    public interface IBankOperation {
        //not show the detail process in here .
        //only show what can you do.
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void CheckBalance(string userName, string password);
        void Transfer(string fromAccountNo,string toAccountNo,double Amount);
    }
}
