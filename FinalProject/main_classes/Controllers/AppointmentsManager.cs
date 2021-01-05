using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FinalProject.Main_Classes.Controllers
{
    public interface ISaveLoadAppointments
    {
        void SaveAppointments(string path, List<Appointment> appointments);
        List<Appointment> LoadAppointments(string path);
    }

    public class AppointmentsManager
    {
        public AppointmentsManager(string filePath, ISaveLoadAppointments saveLoader)
        {
            FilePath = filePath;
            SaveLoader = saveLoader;
            Appointments = saveLoader.LoadAppointments(filePath);
        }

        public List<Appointment> Appointments { get; set; }
        public string FilePath { get; }
        public ISaveLoadAppointments SaveLoader { get; }

        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
            SaveLoader.SaveAppointments(FilePath, Appointments);
        }

        public bool RemoveAppointment(Appointment appointment)
        {
            var result = Appointments.Remove(appointment);
            if (!result) return false;
            SaveLoader.SaveAppointments(FilePath, Appointments);
            return true;
        }
    }

    public class JsonSaveLoadAppointments : ISaveLoadAppointments
    {
        public void SaveAppointments(string filePath, List<Appointment> appointments)
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(appointments));
        }
        public List<Appointment> LoadAppointments(string path)
        {
            if (File.Exists(path))
            {
                return JsonSerializer.Deserialize<List<Appointment>>(File.ReadAllText(path));
            }
            File.Create(path).Close();
            var appointments=new List<Appointment>();
            SaveAppointments(path,appointments);
            return appointments;
        }
    }
}
