using System;
using System.Collections.Generic;
using FinalProject.Main_Classes;

namespace FinalProject.Interfaces
{
    public interface IDoctor
    {
        List<DayOfWeek> WorkingDays { get; set; }
        List<Appointment> Appointments { get; set; }
        int VisitDuration { get; }

    }
}
