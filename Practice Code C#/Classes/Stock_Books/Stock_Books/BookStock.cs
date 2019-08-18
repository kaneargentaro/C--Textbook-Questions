using System;
using System.Collections.Generic;


namespace Stock_Books
{
    class BookStock
    { 
        private string _quantity;
        public string quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private string _description;
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _price;
        public string price
        {
            get { return _price; }
            set { _price = value; }
        }
        public BookStock(string quantity, string descirption, string price)
        {
            this._quantity = quantity;
            this._description = description;
            this._price = price;
        }
    }
}
