using System;
namespace OOPTest3 {
    internal class Person {
       
        private string Name,Email;
        private int Age;
        private string Address;

        public void SetName(string name) {
            if (string.IsNullOrEmpty(name)) {
                throw new ArgumentNullException("invalid Name");
            }
            Name = name;
        }
        public string GetName() {
            return Name;
        }

        public void SetAge(int age) {
            if(age < 0) {
                throw new ArgumentOutOfRangeException("your age must be greater than 0");
            }
            Age = age;
        }
        public int GetAge() {
            return Age;
        }
        public void SetEmail(string email) {
            if (!email.Contains("@")) {
                throw new ArgumentException("Invalid email format.");
            }
            Email = email;
        }
        public void SetAddress(string address) {
            if (string.IsNullOrEmpty(address)) {
                throw new ArgumentNullException("invalid Address");
            }
            Address = address;
        }
        public void About() {
            Console.WriteLine("Hello,My name is "+Name);
            Console.WriteLine("My email is " + Email);
            Console.WriteLine("I am " +Age+" years old");
            Console.WriteLine("Currently,I live in " + Address);
        }
    }
}
