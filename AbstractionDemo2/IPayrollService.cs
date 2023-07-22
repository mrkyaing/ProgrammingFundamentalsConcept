
using System;

namespace AbstractionDemo2 {
    public interface IPayrollService {
        decimal CalculatePayroll(decimal basicSalary, decimal allowlance, decimal deduction);
        decimal CalculateAnualBonus(DateTime joinedDate,decimal basicSalary);
        //1 year .. 30% of basic Salary
        //2 year .. 60% of basic Salary
        //3 year .. 90% of basic Salary
        //4 year ++100% of basic Salary
    }
}
