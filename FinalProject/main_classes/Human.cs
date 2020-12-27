using System.Diagnostics;

namespace FinalProject
{
    public enum Gender { MAN, WOMAN, NONE };

    class Human
    {
        string phoneNum, nationalCode;
        public Human(string firstName, string lastName, string nationalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode
        {
            get => nationalCode;
            set
            {
                Debug.Assert(value.Length == 10);
                //to ensure that the string is of numeric type
                Debug.Assert(int.TryParse(value, out _));
                nationalCode = value;
            }
        }
        public string PhoneNumber
        {
            get => phoneNum;
            set
            {
                if (value[0] == '0')
                    value = value.Substring(1);
                Debug.Assert(value.Length == 10);   // sample --> [0]912 345 6789
                //to ensure that the string is of numeric type
                Debug.Assert(int.TryParse(value, out int n));
                phoneNum = value;
            }
        }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
