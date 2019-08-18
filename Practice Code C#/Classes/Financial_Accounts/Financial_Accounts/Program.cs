using System;

namespace Financial_Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(1000.00M);
            CreditCard credit = new CreditCard(0.00M, 1000.00M);
            TermDeposit term = new TermDeposit(savings.Balance, 100);

            Console.WriteLine(savings);
            Console.WriteLine(credit);


            credit.Payment(100.00M);

            Console.WriteLine(credit);

            savings.Withdraw(600.00M);
            savings.Withdraw(600.00M);
            credit.Purchase(600.00M);
            credit.Purchase(600.00M);


            Console.WriteLine(savings);
            Console.WriteLine(credit);
            Console.WriteLine(term);
        }
    }
}
