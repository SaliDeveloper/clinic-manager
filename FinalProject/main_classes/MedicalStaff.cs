using System.Diagnostics;
using FinalProject.Interfaces;

namespace FinalProject.Main_Classes
{
    public class MedicalStaff : IPerson, ISalaried
    {
        private int _salary;
        private double _tax;

        public MedicalStaff(IProfile profile, IBankAccount bankAccount)
        {
            BankAccount = bankAccount;
            Profile = profile;
        }

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
        public double Tax
        {
            get => _tax;
            set
            {
                Debug.Assert(value >= 0.0 && value <= 1.0);
                _tax = value;
            }
        }
        protected int Wage { get; set; }

        public void GetSalary()
        {
            double realSalary = (1.0 - _tax) * Salary + Wage;
            BankAccount.IncreaseBalance((int)realSalary);
        }
    }
}
