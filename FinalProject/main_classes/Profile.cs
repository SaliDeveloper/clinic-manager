using System;
using System.Diagnostics;
using FinalProject.Main_Classes.Controllers;
using Newtonsoft.Json;

namespace FinalProject.Main_Classes
{
    public enum Gender { Man, Woman, None};

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

        public Profile() { }

        public Profile(string firstName, string lastName, string nationalCode, Gender gender = Gender.None)
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
                //to ensure that the string is of numeric type
                Debug.Assert(long.TryParse(value, out _));
                _nationalCode = value;
            }
        }

        public string PhoneNumber { get; set; } = "";
        public Gender Gender { get; set; }
    }
}
