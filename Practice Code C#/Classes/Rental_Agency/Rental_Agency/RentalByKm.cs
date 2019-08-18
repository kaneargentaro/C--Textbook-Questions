using System;


namespace Rental_Agency
{
    class RentalByKm : Rental
    {
        private int _Rentedkms;
        public int Rentedkms
        {
            get { return _Rentedkms; }
            set { value = _Rentedkms; }
        }
        public RentalByKm(Person firstname, int rentedkms)
        {
            Person _Firstname = firstname;
            _Rentedkms = rentedkms;
        }
        public double RentalByKmCost()
        {
            double s = ((30 + (0.50 * _Rentedkms)));
            return ((s * 0.10) + s);
        }
        public override string ToString()
        {
            return string.Format("Rental for 10km  - $38.50 ");
        }
    }
}
