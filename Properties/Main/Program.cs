using System;
using Bank_In_Csharp.Properties.Main;

namespace Bank_In_Csharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Account account = new Account();
            account.Deposit(1500.00);
            account.Deposit(1000.00);
            account.Deposit(100.00);
            account.Withdrawl(1500.00);

            Statement statement = new Statement(account.GetTransactions());
            statement.DisplayStatement();
        }
    }
}
