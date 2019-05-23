using Bank_In_Csharp.Properties.Main;
using NUnit.Framework;
using System;
namespace Bank_In_Csharp.Properties.Test.Unit_Tests
{
    public class TranscationTest
    {
        [Test, Description("Creating a new instance of transaction sets transactionDate")]
        public void SetTransactionDate()
        {
            Transaction transaction = new Transaction("23/05/19", 10.00, "Deposit", 20.00);
            Assert.AreEqual("23/05/19", transaction.GetTransactionDate());
        }

        [Test, Description("Creating a new instance of transaction sets transactionAmount")]
        public void SetTransactionAmount()
        {
            Transaction transaction = new Transaction("23/05/19", 10.00, "Deposit", 20.00);
            Assert.AreEqual(10.00, transaction.GetTransactionAmount());
        }

        [Test, Description("Creating a new instance of transaction sets transactionType")]
        public void SetTransactionType()
        {
            Transaction transaction = new Transaction("23/05/19", 10.00, "Deposit", 20.00);
            Assert.AreEqual("Deposit", transaction.GetTransactionType());
        }

        [Test, Description("Creating a new instance of transaction sets transactionBalance")]
        public void SetCurrentBalance()
        {
            Transaction transaction = new Transaction("23/05/19", 10.00, "Deposit", 20.00);
            Assert.AreEqual(20.00, transaction.GetCurrentBalance());
        }
    }
}
