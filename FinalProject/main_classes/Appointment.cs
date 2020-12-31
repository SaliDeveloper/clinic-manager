using System;

namespace FinalProject.Main_Classes
{
    public class Appointment
    {
        public bool Status { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public Patient Patient { get; set; }
        public Dentist Dentist { get; set; }
    }
}
