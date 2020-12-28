using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    interface IDoctor
    {
        List<DayOfWeek> WorkingDays { get; set; }
        List<Patient> Patients { get; set; }
        int VisitDuration { get; }

    }
}
