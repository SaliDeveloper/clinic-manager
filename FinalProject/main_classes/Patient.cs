using FinalProject.Interfaces;

namespace FinalProject.Main_Classes
{
    public class Patient : IPerson, IHavingUserAccount
    {
        public Patient()
        {
            Profile = new Profile();
        }

        public Patient(IProfile profile, UserAccount account = null, Insurance insurance = null)
        {
            Profile = profile;
            Account = account ?? new UserAccount();
            Insurance = insurance;
        }

        public long Id => long.Parse(Profile.NationalCode);
        public UserAccount Account { get; }
        public IProfile Profile { get; set; }
        internal Insurance Insurance { get; set; }

        //public static bool operator ==(Patient a, Patient b)
        //{
        //    return !(a is null) && !(b is null) && Equals(a.Id, b.Id);
        //}
        //public static bool operator !=(Patient a, Patient b) => !(a == b);

        //public override bool Equals(object obj) => this == obj as Patient;

        public override string ToString()
        {
            return Profile.FirstName + " " + Profile.LastName;
        }
    }
}
