using FinalProject.Interfaces;
using System.Collections.Generic;

namespace FinalProject.Main_Classes
{
    public class Shareholder
    {
        private static long _totalFinance;
        public static Dictionary<IPerson, int> ShareHolders { get; } = new Dictionary<IPerson, int>();

        public static long TotalFinance { get => _totalFinance; set => _totalFinance = value; }

        public void AddCapitalist(IPerson person, int shares)
        {
            ShareHolders.Add(person, shares);
            _totalFinance += shares;
        }


    }
}
