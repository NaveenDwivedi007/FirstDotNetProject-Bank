using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankLib;

namespace bankApp
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal bal = 0;
                foreach (var transaction in transactions)
                {
                    bal += transaction.Amount;
                } 
                return bal;
            }
        }

        private List<Transaction> transactions = new List<Transaction>();
        
        private static int accountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.makeDeposit(initialBalance, DateTime.Now, "initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void makeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (this.Balance-amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this transaction");
            }
            transactions.Add(new Transaction(-amount, date, note));

        }
        public void makeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            transactions.Add(new Transaction(amount, date, note));
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tamount\tnote");
            foreach (var transaction in transactions)
            {
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.AmountInWord}\t{transaction.Note}");
            }

            return report.ToString();
        }

    }
}
