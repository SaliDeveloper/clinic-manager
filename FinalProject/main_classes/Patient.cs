using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Patient : IPerson
    {
        public Patient(IProfile profile, Insurance insurance = null)
        {
            Profile = profile;
            Insurance = insurance;
        }

        public IProfile Profile { get; set; }
        internal Insurance Insurance { get; set; }
    }
}
