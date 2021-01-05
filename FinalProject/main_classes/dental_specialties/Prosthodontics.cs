using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Main_Classes.Dental_Specialties
{
    [JsonConverter(typeof(Prosthodontics))]
    class Prosthodontics : Dentist
    {
        private static long _salaryBase = 100;

        public Prosthodontics(IProfile person, IBankAccount bankAccount,
            List<DayOfWeek> attendances) : base(person, bankAccount, attendances)
        {
        }
        public override int VisitDuration => 60;
        public override long SalaryBase { get => _salaryBase; set => _salaryBase = value; }
    }
}
