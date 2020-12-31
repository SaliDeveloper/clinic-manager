using System;
using System.Collections.Generic;

namespace FinalProject.Main_Classes.Dental_Specialties
{
    class Periodontics : Dentist
    {
        public Periodontics(IProfile person, IBankAccount bankAccount, int visitDuration,
            List<DayOfWeek> workingDays) : base(person, bankAccount, visitDuration, workingDays)
        {
        }
    }
}
