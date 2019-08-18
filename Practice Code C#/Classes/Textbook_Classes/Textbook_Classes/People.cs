using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Textbook_Classes
{
   public class People
    {
        private const int MAX_EXPERTS = 5;
        private string _FamilyName;
        public string FamilyName
        {
            get { return _FamilyName; }
            set { _FamilyName = value; }
        }

        private string _GivenName;
        public string GivenName
        {
            get { return _GivenName; }
            set { _GivenName = value; }
        }

        public People(string familyName, string givenName)
        {
            _FamilyName = familyName;
            _GivenName = givenName;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", _FamilyName, _GivenName);
        }

        private Expert[] _Expertise = new Expert[People.MAX_EXPERTS];
        public void AddExpert(Expert newexperts)
        {
            for (int i = 0; i < _Expertise.Length; i++)
            {
                if (_Expertise[i] == null)
                {
                    _Expertise[i] = newexperts;
                    break;
                }
            }
        }

        public void PrintExpert()
        {
            Console.WriteLine("{0}", this);
            foreach (Expert r in _Expertise)
            {
                if (r == null)
                    continue;

                Console.WriteLine("\t{0}", r);
            }
            Console.WriteLine();
        }
        public void PrintPeople()
        {
            Console.WriteLine("{0}", this);
        }
    }
}

