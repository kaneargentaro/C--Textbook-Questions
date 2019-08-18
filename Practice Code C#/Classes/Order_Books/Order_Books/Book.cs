using System;
using System.Collections.Generic;

namespace Order_Books
{
    class Book : Order
    {
       
        private string _Author;
        public string Author
        {
            get { return _Author; }          
        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
        }

        private string _Publisher;
        public string Publisher
        {
            get { return _Publisher; }    
        }

        private int _Year;
        public int Year
        {
            get { return _Year; }
        }

        public Book(string author, string title, string publisher, int year)
        {
            this._Author = author;
            this._Title = title;
            this._Publisher = publisher;
            this._Year = year;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}.", _Author, _Title, _Publisher, _Year);
        }
    }
}
