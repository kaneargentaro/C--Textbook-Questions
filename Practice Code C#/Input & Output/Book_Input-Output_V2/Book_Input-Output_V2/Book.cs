using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace Book_Input_Output_V2

{
    [Serializable]
    class Book
    {
        public Book[] book = new Book[4];

        private string _Author;
        public string Author
        {
            get {return _Author;}
            set {_Author = value; }
        }
        private string _Title ;
        public string Title
        {
            get {return _Title;}
            set {_Title = value; }
        }
        private string _Edition;
        public string Edition
        {
            get {return _Edition;}
            set {_Edition = value; }
        }
        private string _Publisher;
        public string Publisher
        {
            get {return _Publisher;}
            set {_Publisher = value; }
        }
        private string _Year;
        public string Year
        {
            get {return _Year;}
            set {_Year = value; }
        }
       public Book(string author, string title, string edition, string publisher, string year)
        {
            _Author = author;
            _Title = title;
            _Edition = edition;
            _Publisher = publisher;
            _Year = year;
        }
        public override string ToString()
        {
            return string.Format("{0}, '{1}', Edition: {2}, {3}, {4}.", _Author, _Title, _Edition, _Publisher, _Year);
        }
    }
}
