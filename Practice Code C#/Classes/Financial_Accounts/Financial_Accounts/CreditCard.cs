using System;


namespace Financial_Accounts
{
    class CreditCard : Account
    {
        public CreditCard(decimal balance, decimal limit) : base(balance)
        {
            _Limit = limit;

        }

        private decimal _Limit;
        public decimal Limit
        {
            get { return _Limit; }
            set { _Limit = value; }
        }

        public void Payment(decimal amount)
        {
            balance += amount;
        }

        public bool Purchase(decimal amount)
        {
            bool result = true;

            if (-balance + amount <= _Limit)
                balance -= amount;
            else
                result = false;

            return result;
        }

        public new decimal Balance
        {
            get { return -balance; }
        }

        public override string ToString()
        {
            string result;

            if (balance < 0)
                result = string.Format("Balance: {0:c} owed", -balance);
            else if (balance == 0)
                result = base.ToString();
            else
                result = base.ToString() + " in credit";

            result += ", limit " + _Limit.ToString("c");

            return result;
        }
    }
}