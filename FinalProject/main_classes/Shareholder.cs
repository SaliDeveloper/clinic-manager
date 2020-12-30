using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Shareholder
    {
        static long totalFinance;
        static Dictionary<IPerson, int> shareHolders = new Dictionary<IPerson, int>();

        public static long TotalFinance { get => totalFinance; set => totalFinance = value; }

        public void AddCapitalist(IPerson person, int shares)
        {
            shareHolders.Add(person, shares);
            totalFinance += shares;
        }


    }
}
