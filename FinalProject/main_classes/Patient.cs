using FinalProject.Interfaces;
using FinalProject.Main_Classes.Controllers;
using Newtonsoft.Json;

namespace FinalProject.Main_Classes
{
    public class Patient : IPerson, IHavingUserAccount
    {
        public Patient()
        {
            Profile = new Profile();
            UserAccount = new UserAccount();
        }

        public Patient(IProfile profile, UserAccount account = null, Insurance insurance = null)
        {
            Profile = profile;
            UserAccount = account ?? new UserAccount();
            Insurance = insurance;
        }

        public long Id => long.Parse(Profile.NationalCode);
        public UserAccount UserAccount { get; }
        [JsonConverter(typeof(JsonDataConverter<Profile>))]
        public IProfile Profile { get; set; }
        internal Insurance Insurance { get; set; }

        public override string ToString()
        {
            return Profile.FirstName + " " + Profile.LastName;
        }
    }
}
