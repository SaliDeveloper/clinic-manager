﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Periodontics : Dentist
    {
        public Periodontics(IProfile person, IBankAccount bankAccount, int visitDuration,
            List<DayOfWeek> workingDays) : base(person, bankAccount, visitDuration, workingDays)
        {
        }
    }
}