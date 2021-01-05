using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Main_Classes.Dental_Specialties
{
    [JsonConverter(typeof(Orthodontics))]
    class Orthodontics : Dentist
    {
        private static long _salaryBase = 100;

        public Orthodontics(IProfile person, IBankAccount bankAccount,
            List<DayOfWeek> attendances) : base(person, bankAccount, attendances)
        {
        }

        public override int VisitDuration => 30;
        public override long SalaryBase { get => _salaryBase; set => _salaryBase = value; }
    }
}
