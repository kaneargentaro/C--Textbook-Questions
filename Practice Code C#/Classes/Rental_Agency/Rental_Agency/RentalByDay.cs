using System;


namespace Rental_Agency
{
    class RentalByDay : Rental
    {
        private int _Renteddays;
        public int Renteddays
        {
            get { return _Renteddays; }
            set { value = _Renteddays; }
        }
        public RentalByDay(Person firstname, int renteddays)
        {
            Person _Firstname = firstname;
            _Renteddays = renteddays;


        }

        public double RentalByDayCost()
        {
            double s= (100 * _Renteddays);;
            return s;
        }
        public override string ToString()
        {
            return string.Format("Rental for 10 days  - $1,000.00");
        }
    }
}
