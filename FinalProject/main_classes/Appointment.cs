using System;

namespace FinalProject.Main_Classes
{
    public class Appointment
    {
        public Appointment(Patient patient, Dentist dentist, DateTime startTime, bool status = false)
        {
            Patient = patient;
            Dentist = dentist;
            StartTime = startTime;
            Status = status;
        }
        public DateTime StartTime { get; set; }
        public int Duration => Dentist.VisitDuration;
        public string Specialty => Dentist.GetSpecialty();
        public Patient Patient { get; set; }
        public Dentist Dentist { get; set; }
        public bool Status { get; set; }

        public override string ToString()
        {
            return Patient.ToString() + "#" + Dentist.ToString() + "#" + StartTime.ToString("G");
        }
    }
}
