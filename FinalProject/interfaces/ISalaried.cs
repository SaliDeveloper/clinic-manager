namespace FinalProject.Interfaces
{
    interface ISalaried
    {
        int Salary { get; set; }

        //Tax rate
        //In the range of 0.0 to 1.0
        double Tax { get; set; }

        void GetSalary();
    }
}
