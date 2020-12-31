using System;
using System.Collections.Generic;

namespace FinalProject.Main_Classes.Dental_Specialties
{
    class Prosthodontics : Dentist
    {
        public Prosthodontics(IProfile person, IBankAccount bankAccount, int visitDuration,
            List<DayOfWeek> workingDays) : base(person, bankAccount, visitDuration, workingDays)
        {
        }
    }
}
