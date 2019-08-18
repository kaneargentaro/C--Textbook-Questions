using System;

namespace Financial_Accounts
{
    class Account
    {
        protected Account(decimal balance)
        {
            _Balance = balance;
        }

        protected decimal balance;
        private decimal _Balance;

        public decimal Balance
        {
            get { return _Balance; }
        }


        public override string ToString()
        {
            return string.Format("Balance: {0:c}", _Balance);
        }
    }
}
