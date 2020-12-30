using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Patient
    {
        public Patient(IProfile person, Insurance insurance = null)
        {
            Person = person;
            Insurance = insurance;
        }

        public IProfile Person { get; set; }
        internal Insurance Insurance { get; set; }
    }
}
