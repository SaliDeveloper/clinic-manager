using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Main_Classes.Dental_Specialties
{
    [JsonConverter(typeof(RestorativeDentistry))]
    class RestorativeDentistry : Dentist
    {
        private static long _salaryBase = 100;
        
        public RestorativeDentistry(IProfile person, IBankAccount bankAccount,
            List<DayOfWeek> attendances) : base(person, bankAccount, attendances)
        {
        }
        public override int VisitDuration => 10;
        public override long SalaryBase { get => _salaryBase; set => _salaryBase = value; }
    }
}
