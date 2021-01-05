using System;

namespace FinalProject.Main_Classes
{
    public class Appointment
    {
        public Appointment() { PatientId = DoctorId = Id = -1; }
        public Appointment(long patientId, long doctor, DateTime startTime, int id = -1)
        {
            PatientId = patientId;
            DoctorId = doctor;
            StartTime = startTime;
            Id = id;
        }

        public long Id { get; set; }
        public DateTime StartTime { get; set; }
        public long PatientId { get; set; }
        public long DoctorId { get; set; }
    }
}
