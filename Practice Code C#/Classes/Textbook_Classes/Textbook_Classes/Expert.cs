using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_Classes
{
    public abstract class Expert
    {
        private People _Experts;
        public People Experts
        {
            get { return _Experts; }
        }

        public Expert(People experts)
        {
            _Experts = experts;
            if (experts != null)
            {
                experts.AddExpert(this);
            }
        }
    }
}