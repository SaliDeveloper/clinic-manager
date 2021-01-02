using System;
using System.Collections.Generic;

namespace FinalProject.Main_Classes.Dental_Specialties
{
    class RestorativeDentistry : Dentist
    {
        public RestorativeDentistry(IProfile person, IBankAccount bankAccount, int visitDuration,
            List<DayOfWeek> workingDays) : base(person, bankAccount, visitDuration, workingDays)
        {
        }
        public override string GetSpecialty() => "Restorative Dentistry";
    }
}
