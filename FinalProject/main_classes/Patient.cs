using FinalProject.Interfaces;
using System.Collections.Generic;

namespace FinalProject.Main_Classes
{
    public class Patient : IPerson
    {
        public Patient(IProfile profile, Insurance insurance = null)
        {
            Profile = profile;
            Insurance = insurance;
            Appointments = new List<Appointment>();
        }

        public IProfile Profile { get; set; }
        public List<Appointment> Appointments { get; private set; }
        internal Insurance Insurance { get; set; }

        public bool AddAppointment(Appointment appointment)
        {
            if (appointment.Patient != this) return false;
            Appointments.Add(appointment);
            return true;
        }

        public static bool operator ==(Patient a, Patient b)
        {
            return !(a is null) && !(b is null) && a.Profile == b.Profile;
        }

        public static bool operator !=(Patient a, Patient b) => !(a == b);

        public override bool Equals(object obj)
        {
            var patient = obj as Patient;
            if (patient == null) return false;
            return this == patient;
        }

        public override int GetHashCode() => (Profile != null ? Profile.GetHashCode() : 0);
    }
}
