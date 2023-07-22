using System;

namespace AbstractionDemo2 {
    public class Program {
        static void Main() {
            Staff s1 = new Staff()
            {
                Name = "Su Su",
                Email = "susu@gmail.com",
                StaffId = "s101",
                BasicSalary = 350000,
                Address = "YGN",
                Department = "HR",
                Positon = "Admin",
                JoinedDate = Convert.ToDateTime("2021-10-11"),
            };
           
            IPayrollService runPayroll=new PayrollService();
           decimal salary= runPayroll.CalculatePayroll(s1.BasicSalary, 10000, 0);//36000
            Console.WriteLine($"Hello,{s1.Name} your current month salary is {salary}");
           decimal bonus=  runPayroll.CalculateAnualBonus(s1.JoinedDate, s1.BasicSalary);
            Console.WriteLine($"Congrulate :You get the anual bonus {bonus} MMK");//2023-2021
            ICreditCard bankAccount = new BankAccount();
            bankAccount.GetSGExchangeRate(750);
            bankAccount.GetUSDollorExchangeRate(550);
            Console.WriteLine("===============");
            Staff s2 = new Staff(){
                Name = "Min Min",
                Email = "minmin@gmail.com",
                StaffId = "s102",
                BasicSalary = 400000,
                Address = "YGN",
                Department = "HR",
                Positon = "Admin",
                JoinedDate = Convert.ToDateTime("2017-10-11")
            };
            decimal salary2 = runPayroll.CalculatePayroll(s2.BasicSalary, 10000, 35000);// ?????
            Console.WriteLine($"Hello,{s2.Name} your current month salary is {salary2}");
            decimal bonus2 = runPayroll.CalculateAnualBonus(s2.JoinedDate, s2.BasicSalary);
            Console.WriteLine($"Congrulate :You get the anual bonus {bonus2} MMK");//????
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
