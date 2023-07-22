using OOPDay4;


Console.WriteLine("Abstraction Demo!");
BankAccount myaccount = new BankAccount();
myaccount.AccountName = "Su Su";
myaccount.AccountNo = "11111";
myaccount.OpeningDate = DateTime.Now;//getting the today date 
myaccount.Balance = 1000;
myaccount.AccountType = "Saving";
myaccount.DisplayInfo();

IBankOperation bankOperation = new BankOperation(myaccount);
bankOperation.Deposit(1000);
bankOperation.Deposit(1000);
Console.WriteLine("Your Current Balance "+ myaccount.Balance);//3000
bankOperation.Withdraw(1000);
Console.WriteLine("Your Current Balance " + myaccount.Balance);//2000
BankAccount yourAccount=new BankAccount();
yourAccount.AccountName = "Mg Mg ";
yourAccount.AccountNo = "22222";
yourAccount.OpeningDate =Convert.ToDateTime("2023-01-10");
yourAccount.Balance = 500000;
yourAccount.AccountType = "Saving";
bankOperation.Transfer(yourAccount.AccountNo, myaccount.AccountNo, 3000);
Console.WriteLine("Your Current Balance " + myaccount.Balance);//5000