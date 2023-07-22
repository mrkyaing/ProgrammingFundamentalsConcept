using System;

namespace AbstractionDemo2 {
    public class Staff :IShowDetail {
        public string StaffId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal BasicSalary { get; set; }
        public DateTime JoinedDate { get; set; }
        public string Positon { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }

        public void DisplayInfo() {
            Console.WriteLine("Staff Information Here");
            Console.WriteLine($"Id {StaffId}");
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Email {Email}");
            Console.WriteLine($"Address {Address}");
            Console.WriteLine($"Joined Date {JoinedDate}");
            Console.WriteLine($"Basic Salary {BasicSalary}");
            Console.WriteLine($"Department {Department}");
            Console.WriteLine($"Positon {Positon}");
        }
    }
}
