using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Main_Classes.Dental_Specialties
{
    [JsonConverter(typeof(PediatricDentistry))]
    class PediatricDentistry : Dentist
    {
        private static long _salaryBase = 100;

        public PediatricDentistry(IProfile person, IBankAccount bankAccount,
            List<DayOfWeek> attendances) : base(person, bankAccount, attendances)
        {
        }
        public override int VisitDuration => 40;
        public override long SalaryBase { get => _salaryBase; set => _salaryBase = value; }
    }
}
