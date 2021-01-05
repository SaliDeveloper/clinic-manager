using System;
using FinalProject.Interfaces;
using System.Diagnostics;

namespace FinalProject.Main_Classes
{
    public class MedicalStaff : IPerson, ISalaried
    {
        private int _salary;

        public MedicalStaff(IProfile profile, IBankAccount bankAccount)
        {
            BankAccount = bankAccount;
            Profile = profile;
        }

        public long Id => long.Parse(Profile.NationalCode);
        public IProfile Profile { get; set; }
        public IBankAccount BankAccount { get; set; }
        public int Salary
        {
            get => _salary;
            set
            {
                Debug.Assert(value >= 0);
                _salary = value;
            }
        }

        protected int Wage { get; set; }

        public void GetSalary()
        {
            BankAccount.IncreaseBalance(Salary + Wage);
        }

        public static bool operator ==(MedicalStaff a, MedicalStaff b)
        {
            return !(a is null) && !(b is null) && Equals(a.Profile, b.Profile);
        }
        public static bool operator !=(MedicalStaff a, MedicalStaff b) => !(a == b);
        public override bool Equals(object obj) => this == obj as MedicalStaff;
        public override int GetHashCode() => 1;
    }
}
