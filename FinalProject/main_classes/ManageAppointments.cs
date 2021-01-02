using System.Collections.Generic;

namespace FinalProject.Main_Classes
{
    public interface ISaveLoadAppointments
    {
        void SaveAppointments();
        List<Appointment> LoadAppointments(string path);
    }

    public class ManageAppointments
    {
        public ManageAppointments(string filePath, ISaveLoadAppointments saveLoader)
        {
            FilePath = filePath;
            SaveLoader = saveLoader;
            Appointments = saveLoader.LoadAppointments(filePath);
        }

        public List<Appointment> Appointments { get; set; }
        public string FilePath { get; }
        public ISaveLoadAppointments SaveLoader { get; }

        public void AddAppointments(Appointment appointment)
        {
            Appointments.Add(appointment);
            SaveLoader.SaveAppointments();
        }

        public bool RemoveAppointments(Appointment appointment)
        {
            var result = Appointments.Remove(appointment);
            SaveLoader.SaveAppointments();
            return result;
        }
    }
}
