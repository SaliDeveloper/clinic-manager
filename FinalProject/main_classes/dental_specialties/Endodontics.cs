using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Main_Classes.Dental_Specialties
{
    [JsonConverter(typeof(Endodontics))]
    class Endodontics : Dentist
    {
        private static long _salaryBase=100;
        public Endodontics(IProfile person, IBankAccount bankAccount,
            List<DayOfWeek> workingDays) : base(person, bankAccount, workingDays)
        {
        }

        public override long SalaryBase { get => _salaryBase; set => _salaryBase = value; }
        public override int VisitDuration => 20;
    }
}
