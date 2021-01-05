using System;
using System.Diagnostics;

namespace FinalProject.Main_Classes
{
    public enum Gender { Man, Woman };

    public interface IProfile
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string NationalCode { get; set; }
        Gender Gender { get; set; }
    }

    public class Profile : IProfile
    {
        private string _nationalCode;
        public Profile(string firstName, string lastName, string nationalCode, Gender gender = Gender.Man)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            Gender = gender;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode
        {
            get => _nationalCode;
            set
            {
                ////to ensure that the string is of numeric type
                Debug.Assert(long.TryParse(value, out _));
                _nationalCode = value;
            }
        }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }

        public static bool operator ==(Profile a, Profile b)
        {
            return !(b is null) && !(a is null) && a.NationalCode == b.NationalCode;
        }
        public static bool operator !=(Profile a, Profile b) => !(a == b);
        public override bool Equals(object obj) => this == obj as Profile;
        public override int GetHashCode() => NationalCode != null ? NationalCode.GetHashCode() : 0;
    }
}
