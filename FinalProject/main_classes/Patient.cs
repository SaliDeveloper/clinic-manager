using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Patient : Human
    {
        private Insurance insurance;

        public Patient(string name, string lastName, string nationalCode)
            : base(name, lastName, nationalCode)
        {
        }
    }
}
