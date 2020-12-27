using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    interface ISalaried
    {
        BankAccount Account { get; set; }

        int Salary { get; set; }

        //Tax rate
        //In the range of 0.0 to 1.0
        double Tax { get; set; }

        void GetSalary();
    }
}
