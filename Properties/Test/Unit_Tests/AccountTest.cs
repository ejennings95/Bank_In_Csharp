using Bank_In_Csharp.Properties.Main;
using NUnit.Framework;
using System;
namespace Bank_In_Csharp.Properties.Test.Unit_Tests
{
    public class AccountTest
    {

        [Test, Description("Original Balance is 0.00")]
        public void DefaultBalance()
        {
            Account account = new Account();
            Assert.AreEqual(0.00, account.GetBalance());
        }

        [Test, Description("Deposited money goes into Balance")]
        public void Deposit()
        {
            Account account = new Account();
            account.Deposit(100.00);
            Assert.AreEqual(100.00, account.GetBalance());
        }

        [Test, Description("Withdrawn money is taken away from Balance")]
        public void Withdrawl()
        {
            Account account = new Account();
            account.Deposit(100.00);
            account.Withdrawl(50.00);
            Assert.AreEqual(50.00, account.GetBalance());
        }

        [Test, Description("Account starts with no transactions")]
        public void DefaultTransactions()
        {
            Account account = new Account();
            Assert.AreEqual(0, account.GetTransactions().Count);
        }

        [Test, Description("Account stores transaction when money deposited")]
        public void AddTransactionsViaDeposit()
        {
            Account account = new Account();
            account.Deposit(100.00);
            Assert.AreEqual(1, account.GetTransactions().Count);
        }

        [Test, Description("Account stores transaction when money withdrawn")]
        public void AddTransactionsViaWithdrawl()
        {
            Account account = new Account();
            account.Deposit(100.00);
            Assert.AreEqual(1, account.GetTransactions().Count);
            account.Withdrawl(10.00);
            Assert.AreEqual(2, account.GetTransactions().Count);
        }

        [Test, Description("Unable to withdrawl if insufficient funuds")]
        [ExpectedException(typeof(InsufficientFundsException))]
        public void InsufficientFundsForWithdrawl()
        {
            Account account = new Account();
            account.Withdrawl(100.00);
        }
    }
}
