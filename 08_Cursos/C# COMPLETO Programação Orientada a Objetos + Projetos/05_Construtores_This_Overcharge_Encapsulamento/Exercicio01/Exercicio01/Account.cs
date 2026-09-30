using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio01 {
     class Account {

        private readonly string AccountNumber;
        public string AccountHolder { get;  private set; }
        public double Balance { get;  private set; }

        public Account() { }
        public Account(string accountNumber, string accountHolder) {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0.0;
        }
        public Account(string accountNumber, string accountHolder, double initialBalance) {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

       public void Withdraw(double amount) {
            Balance -= amount + 5.0;
        }
        public override string ToString() {
            return "Account " + AccountNumber + ", Holder: " + AccountHolder + ", Balance: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
