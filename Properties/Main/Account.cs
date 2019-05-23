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
        }

        public void Withdrawl(double amount)
        {
            SetBalance(balance - amount);
            transactions.Add(new Transaction(DateTime.Now.ToString("dd/MM/yy"), amount, "Withdrawl", GetBalance()));
        }
    }
}
