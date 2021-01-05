using System;

namespace FinalProject.Main_Classes
{
    public class Insurance
    {
        public Insurance(DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
        }
        public string Organization { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return ExpirationDate.ToString("d");
        }
    }
}
