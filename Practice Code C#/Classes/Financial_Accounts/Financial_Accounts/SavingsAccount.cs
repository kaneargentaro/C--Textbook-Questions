using System;

namespace Financial_Accounts
{
    class SavingsAccount : Account
    {
        private const decimal DEFAULT_BALANCE = 0.00M;

        public SavingsAccount() : this(DEFAULT_BALANCE)
        {
        }

        public SavingsAccount(decimal balance) : base(balance)
        {
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            bool result = true;

            if (balance >= amount)
                balance -= amount;
            else
                result = false;

            return result;
        }
    }
}
