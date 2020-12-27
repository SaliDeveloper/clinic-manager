namespace FinalProject
{
    class Dentist : MedicalStaff, IDoctor
    {
        public Dentist(string name, string lastName, string nationalCode, string accountNumber)
            : base(name, lastName, nationalCode, accountNumber)
        {
            
        }
    }
}
