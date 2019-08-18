using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Order_Books
{
    class Order
    {
        private const string DEFAULT_CUSTOMER = "UNKNOWN";
        public Order() : this(DEFAULT_CUSTOMER)
        {      
        }
        public Order(string customer)
        {
            this._Customer = customer;
            this._Books = new List<Book>();
        }

        private string _Customer;
        public string Customer
        {
            get { return _Customer; }
        }

        private List<Book> _Books;
        public ReadOnlyCollection<Book> Books
        {
            get { return _Books.AsReadOnly(); }
        }
        public Order(Order source)
        {
            _Customer = source._Customer;
            _Books = new List<Book>(source._Books);
        }

        public void Add(Book book)
        {
            _Books.Add(book);
        }
        public override string ToString()
        {
            return string.Format("Order for {0} containing {1} books.", _Customer, _Books.Count);
        }
    }
}
