using bankLib;
using System;

namespace bankApp
{
    class Bank
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount("Naveen", 10000);
            Console.WriteLine($"bank with account Number {account1.Number} is created by {account1.Owner} with the balance of {account1.Balance}");
            var account2 = new BankAccount("Praveen", 30000);
                account2.makeDeposit(902, DateTime.Now, "earn");
                account2.makeDeposit(93, DateTime.Now, "earn");
                account2.makeWithdrawal(822, DateTime.Now, "rent");
                account2.makeDeposit(974, DateTime.Now, "earn");
                account2.makeDeposit(912, DateTime.Now, "earn");
                account2.makeWithdrawal(9, DateTime.Now, "food");
            Console.WriteLine($"bank with account Number {account2.Number} is created by {account2.Owner} with the balance of {account2.Balance}");
            Console.WriteLine(account2.GetAccountHistory());


        }
    }
}