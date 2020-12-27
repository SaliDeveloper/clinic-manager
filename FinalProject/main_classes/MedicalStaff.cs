using System.Diagnostics;

namespace FinalProject
{
    class MedicalStaff : Human, ISalaried
    {
        int salary;
        double tax;

        public MedicalStaff(string name, string lastName, string nationalCode, string accountNumber)
            : base(name, lastName, nationalCode)
        {
            Account = new BankAccount(accountNumber);
        }

        public BankAccount Account { get; set; }
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
            Account.IncreaseBalance((int)realSalary);
        }
    }
}
