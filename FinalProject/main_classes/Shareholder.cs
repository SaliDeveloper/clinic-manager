using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FinalProject
{
    class Shareholder
    {
        static long totalFinance;
        static Dictionary<Human, int> shareHolders = new Dictionary<Human, int>();

        public static long TotalFinance { get => totalFinance; set => totalFinance = value; }

        public void AddCapitalist(Human person, int shares)
        {
            shareHolders.Add(person, shares);
            totalFinance += shares;
        }


    }
}
