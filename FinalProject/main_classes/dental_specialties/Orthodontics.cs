﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Orthodontics : Dentist
    {
        public Orthodontics(string name, string lastName, string nationalCode,
            string accountNumber, int visitDuration, List<DayOfWeek> workingDays)
            : base(name, lastName, nationalCode, accountNumber, visitDuration, workingDays)
        {
        }
    }
}
