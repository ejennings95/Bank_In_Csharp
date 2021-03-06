﻿using System;
namespace Bank_In_Csharp.Properties.Main
{
    public class Transaction
    {
        public string transactionDate;
        public double transactionAmount;
        public string transactionType;
        public double currentBalance;

        public Transaction(string date, double amount, string type, double balance)
        {
            SetTransactionDate(date);
            SetTransactionAmount(amount);
            SetTransactionType(type);
            SetCurrentBalance(balance);
        }

        public void SetTransactionDate(string date)
        {
            transactionDate = date;
        }

        public string GetTransactionDate()
        {
            return transactionDate;
        }

        public void SetTransactionAmount(double amount)
        {
            transactionAmount = amount;
        }

        public string GetTransactionAmount()
        {
            return String.Format("{0:0.00}", transactionAmount);
        }

        public void SetTransactionType(string type)
        {
            transactionType = type;
        }

        public string GetTransactionType()
        {
            return transactionType;
        }

        public void SetCurrentBalance(double balance)
        {
            currentBalance = balance;
        }

        public string GetCurrentBalance()
        {
            return String.Format("{0:0.00}", currentBalance);
        }
    }
}
