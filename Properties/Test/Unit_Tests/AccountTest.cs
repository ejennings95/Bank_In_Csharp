using Bank_In_Csharp.Properties.Main;
using NUnit.Framework;
using System;
namespace Bank_In_Csharp.Properties.Test.Unit_Tests
{
    public class AccountTest
    {

        [Test, Description("Original Balance is 0.00")]
        public void defaultBalance()
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
    }
}
