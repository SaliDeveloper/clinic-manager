using FinalProject.Interfaces;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.Main_Classes
{
    public abstract class Dentist : MedicalStaff, IDoctor
    {
        public static List<string> Specialties;
        static Dentist()
        {
            var baseType = typeof(Dentist);
            var types = baseType.Assembly.GetTypes().Where(t => t.IsSubclassOf(baseType));
            Specialties = types.Select(type => type.Name).ToList();
        }

        public string Type => GetType().Name;
        public static Newtonsoft.Json.JsonConverter JsonConverter => JsonSubtypesConverterBuilder
            .Of(typeof(Dentist), "_type").Build();

        protected Dentist(IProfile profile, IBankAccount bankAccount
            , List<DayOfWeek> attendances) : base(profile, bankAccount)
        {
            Attendances = attendances;
        }

        public List<DayOfWeek> Attendances { get; set; }
        public abstract int VisitDuration { get; }

        public abstract long SalaryBase { get; set; }

        public override string ToString()
        {
            return "Dr." + Profile.LastName;
        }
    }
}
