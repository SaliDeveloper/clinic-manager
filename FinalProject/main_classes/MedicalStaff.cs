using System.Diagnostics;

namespace FinalProject
{
    class MedicalStaff : ISalaried
    {
        int salary;
        double tax;

        public MedicalStaff(IProfile person, IBankAccount bankAccount)
        {
            BankAccount = bankAccount;
            Person = person;
        }

        public IProfile Person { get; set; }
        public IBankAccount BankAccount { get; set; }
        public int Salary
        {
            get => salary;
            set
            {
                Debug.Assert(value >= 0);
                salary = value;
            }
        }
        public double Tax
        {
            get => tax;
            set
            {
                Debug.Assert(value >= 0.0 && value <= 1.0);
                tax = value;
            }
        }
        protected int Wage { get; set; }

        public void GetSalary()
        {
            double realSalary = (1.0 - tax) * Salary + Wage;
            BankAccount.IncreaseBalance((int)realSalary);
        }
    }
}
