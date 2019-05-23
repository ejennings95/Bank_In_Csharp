using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_In_Csharp.Properties.Main
{
    public class Statement
    {
        public List<Transaction> transactions = new List<Transaction>();
        public StringBuilder statement = new StringBuilder();

        public Statement(List<Transaction> accountTransactions)
        {
            SetTransactions(accountTransactions);
        }

        public void SetTransactions(List<Transaction> accountTransactions)
        {
            transactions = accountTransactions;
        }

        public List<Transaction> GetTransactions()
        {
            return transactions;
        }

        public StringBuilder DisplayStatement()
        {
            statement.Append("date || credit || debit || balance\n");
            foreach (var transaction in transactions)
            {
                statement.Append(transaction.GetTransactionDate());
                if (transaction.GetTransactionType() == "Deposit")
                {
                    statement.Append(" || " + transaction.GetTransactionAmount() + " ||");
                } else if (transaction.GetTransactionType() == "Withdrawl")
                {
                    statement.Append(" || || " + transaction.GetTransactionAmount());
                }
                statement.Append(" || " + transaction.GetCurrentBalance() + "\n");
            }
            Console.WriteLine(statement);
            return statement;
        }
    }
}
