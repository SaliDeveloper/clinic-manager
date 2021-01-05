using FinalProject.Interfaces;
using FinalProject.Main_Classes.Controllers;

namespace FinalProject.Main_Classes
{
    public class Patient : IPerson
    {
        public Patient(IProfile profile, AppointmentsManager manageAppointments, Insurance insurance = null)
        {
            Profile = profile;
            Insurance = insurance;
        }

        public long Id => long.Parse(Profile.NationalCode);
        public IProfile Profile { get; set; }
        internal Insurance Insurance { get; set; }

        public static bool operator ==(Patient a, Patient b)
        {
            return !(a is null) && !(b is null) && Equals(a.Id, b.Id);
        }
        public static bool operator !=(Patient a, Patient b) => !(a == b);

        public override bool Equals(object obj) => this == obj as Patient;

        public override string ToString()
        {
            return Profile.FirstName + " " + Profile.LastName;
        }
    }
}
