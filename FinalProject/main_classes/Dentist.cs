using System;
using System.Collections.Generic;
using System.Diagnostics;
using FinalProject.Interfaces;

namespace FinalProject.Main_Classes
{
    public class Dentist : MedicalStaff, IDoctor
    {
        private int _visitDuration;

        public Dentist(IProfile person, IBankAccount bankAccount, int visitDuration, List<DayOfWeek> workingDays)
            : base(person, bankAccount)
        {
            VisitDuration = visitDuration;
            WorkingDays = workingDays;
        }

        public List<DayOfWeek> WorkingDays { get; set; }
        public List<Appointment> Appointments { get; set; }
        public int VisitDuration
        {
            get => _visitDuration;
            protected set
            {
                Debug.Assert(value > 0);
                _visitDuration = value;
            }
        }
    }

}
