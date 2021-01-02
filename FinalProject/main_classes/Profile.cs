using System;
using System.Diagnostics;

namespace FinalProject.Main_Classes
{
    public enum Gender { Man, Woman };

    public interface IProfile
    {
        string UserName { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string NationalCode { get; set; }
        string PhoneNumber { get; set; }
        Gender Gender { get; set; }
    }

    public class Profile : IProfile
    {
        private string _phoneNum, _nationalCode, _password;
        public Profile(string firstName, string lastName, string nationalCode)
        {
            FirstName = firstName;
            LastName = UserName = lastName;
            NationalCode = Password = nationalCode;
        }

        public Profile(string firstName, string lastName, string nationalCode,string userName,
            string password, Gender gender = Gender.Man): this(firstName, lastName, nationalCode)
        {
            UserName = userName;
            Password = password;
            Gender = gender;
        }

        public string UserName { get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (value.Length < 4)
                    throw new Exception("Password length can't be less than 4 chars");
                _password = value;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode
        {
            get => _nationalCode;
            set
            {
                Debug.Assert(value.Length == 10);
                ////to ensure that the string is of numeric type
                //Debug.Assert(int.TryParse(value, out _));
                _nationalCode = value;
            }
        }
        public string PhoneNumber
        {
            get => _phoneNum;
            set
            {
                if (value[0] == '0')
                    value = value.Substring(1);
                Debug.Assert(value.Length == 10);   // sample --> [0]912 345 6789

                ////to ensure that the string is of numeric type
                //Debug.Assert(int.TryParse(value, out _));

                _phoneNum = value;
            }
        }
        public Gender Gender { get; set; }
    }
}
