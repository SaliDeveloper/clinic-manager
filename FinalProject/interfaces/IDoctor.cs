using FinalProject.Main_Classes;
using System;
using System.Collections.Generic;

namespace FinalProject.Interfaces
{
    public interface IDoctor
    {
        string Type { get; }
        long Id { get; }
        IProfile Profile { get; set; }
        List<DayOfWeek> Attendances { get; set; }
        int VisitDuration { get; }
        long SalaryBase { get; }
    }
}
