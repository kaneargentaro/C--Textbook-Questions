using System;


namespace Financial_Accounts
{
    class TermDeposit : Account
    {
        private decimal _Interestrate;
        public decimal Interestrate
        {
            get { return _Interestrate; }
            set { _Interestrate = value; }
        }
        private int rate = 2;

        private int _Term;
        public int Term
        {
            get { return _Term; }
            set { _Term = value; }
        }

        public TermDeposit(decimal balance, int term) : base(balance)
        {
            this.balance = balance;
            this._Term = term;
        }
        DateTime value = new DateTime(2016, 04, 12);
        public void CalculateInterest(decimal Interestrate)
        {    
            Interestrate = (( rate / 100) * balance * (Term / 365)); 
        }

        public override string ToString()
        {


            return string.Format("Interest paid on your current balance for the term is {0:c}", Interestrate);

        }
    }
}
