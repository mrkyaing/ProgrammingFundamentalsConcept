using System;


namespace AbstractionDemo2 {
    public class BankAccount : ICreditCard {
        public void GetSGExchangeRate(decimal amount) {
            if (amount < 0) 
                throw new ArgumentException("amount is invalid.");
            decimal result = amount * 1565.37m;
            Console.WriteLine($"{amount} SG $={result} MMK");
        }

        public void GetUSDollorExchangeRate(decimal amount) {
            if (amount < 0)
                throw new ArgumentException("amount is invalid.");
            decimal result = amount * 2096.12m;
            Console.WriteLine($"{amount} US $={result} MMK");
        }
    }
}
