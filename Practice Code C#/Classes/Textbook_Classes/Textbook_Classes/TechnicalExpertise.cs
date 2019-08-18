using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_Classes
{
    public class TechnicalExpertise : Expert
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

        public TechnicalExpertise(People experts, string description, string id)
            : base(experts)
        {
            _Description = description;
            _ID = id;
        }

        public override string ToString()
        {
            return string.Format("Technical Expertise: ID: {0} - Description: {1}", _ID, _Description);
        }
    }
}

