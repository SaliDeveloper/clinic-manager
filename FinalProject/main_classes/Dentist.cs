using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FinalProject
{
    abstract class Dentist : MedicalStaff, IDoctor
    {
        int visitDuration;

        public Dentist(string name, string lastName, string nationalCode, string accountNumber
            , int visitDuration, List<DayOfWeek> workingDays)
            : base(name, lastName, nationalCode, accountNumber)
        {
            VisitDuration = visitDuration;
            WorkingDays = workingDays;
        }

        public List<DayOfWeek> WorkingDays { get; set; }
        public List<Patient> Patients { get; set; }
        public int VisitDuration
        {
            get => visitDuration;
            protected set
            {
                Debug.Assert(value > 0);
                visitDuration = value;
            }
        }
    }

}
