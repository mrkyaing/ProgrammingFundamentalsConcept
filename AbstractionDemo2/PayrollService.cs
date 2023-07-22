using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo2 {
    public class PayrollService : IPayrollService {
        public decimal CalculateAnualBonus(DateTime joinedDate,decimal basicSalary) {
            //1 year .. 30% of basic Salary
            //2 year .. 60% of basic Salary
            //3 year .. 90% of basic Salary
            //4 year ++100% of basic Salary
            decimal bouns = 0;
            DateTime today= DateTime.Now.Date;//2023-06-18 2019-06-17
            if (today.Subtract( joinedDate.Date).TotalDays >= (4*365)) {
                bouns = basicSalary ;
            }
            else if (today.Subtract(joinedDate.Date).TotalDays >= (3 * 365)) {
                bouns = basicSalary * 0.90m;
            }
            else if (today.Subtract(joinedDate.Date).TotalDays >= (2 * 365)) {
                bouns = basicSalary * 0.60m;
            }
            else if (today.Subtract(joinedDate.Date).TotalDays >= (1 * 365)) {
                bouns = basicSalary *0.30m;
            }
            return bouns;
        }

        public decimal CalculatePayroll(decimal basicSalary, decimal allowlance, decimal deduction) {
            decimal salary = basicSalary + allowlance - deduction;
            return salary;
        }
    }
}
