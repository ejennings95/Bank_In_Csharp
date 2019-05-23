using System;
namespace Bank_In_Csharp.Properties.Main
{
    public class Account
    {
        public double balance = 0.00;

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

        public void Deposit(double amount)
        {
            SetBalance(balance + amount); 
        }

        public void Withdrawl(double amount)
        {
            SetBalance(balance - amount);
        }
    }
}
