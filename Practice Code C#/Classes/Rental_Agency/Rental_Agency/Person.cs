using System;

namespace Rental_Agency
{
    class Person : Rental
    {
        private string _Lastname;
        public string Lastname
        {
            get { return _Lastname; }
            set { value = _Lastname; }
        }
        private string _Firstname;
        public string Firstname
        {
            get { return _Firstname; }
            set { value = _Firstname; }
        }

        public Person(string lastname, string firstname)
        {
            _Lastname = lastname;
            _Firstname = firstname;
        }
    }
}
