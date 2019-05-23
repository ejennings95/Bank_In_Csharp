using System;
using System.Collections.Generic;

namespace Bank_In_Csharp.Properties.Main
{
    public class Account
    {
        public double balance = 0.00;
        public List<Transaction> transactions = new List<Transaction>();

        public Account()
        {
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double accountBalance)
        {
            balance = accountBalance;
        }

        public List<Transaction> GetTransactions()
        {
            return transactions;
        }

        public void Deposit(double amount)
        {
            SetBalance(balance + amount);
            transactions.Add(new Transaction(DateTime.Now.ToString("dd/MM/yy"), amount, "Deposit", GetBalance()));
            Console.WriteLine("£{0} has been deposited", String.Format("{0:0.00}", amount));
        }

        public void Withdrawl(double amount)
        {
            if ((balance - amount) < 0) throw new InsufficientFundsException("There are not sufficent funds to complete this transaction");
            SetBalance(balance - amount);
            transactions.Add(new Transaction(DateTime.Now.ToString("dd/MM/yy"), amount, "Withdrawl", GetBalance()));
            Console.WriteLine("£{0} has been withdrawn", String.Format("{0:0.00}", amount));
        }
    }
}
