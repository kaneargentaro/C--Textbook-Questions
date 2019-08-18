using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_Classes
{
    class Textbook
    {
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private string _Status;
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public Textbook(string id, string description, string status)
        {
            _Description = description;
            _ID = id;
            _Status = status;
        }
        public override string ToString()
        {
            return string.Format("Textbook Information\nID: {0} - Description: {1} - Status: {2}\nAuthors and Participants:", _ID, _Description, _Status);
        }
        public void PrintTextbook()
        {
            Console.WriteLine("{0}", this);
        }
    }
}
