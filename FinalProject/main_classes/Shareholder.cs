using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FinalProject
{
    class Shareholder
    {
        static long totalFinance;
        static Dictionary<IProfile, int> shareHolders = new Dictionary<IProfile, int>();

        public static long TotalFinance { get => totalFinance; set => totalFinance = value; }

        public void AddCapitalist(IProfile person, int shares)
        {
            shareHolders.Add(person, shares);
            totalFinance += shares;
        }


    }
}
