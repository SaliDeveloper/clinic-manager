using FinalProject.Interfaces;
using System.Collections.Generic;

namespace FinalProject.Main_Classes.Controllers
{
    public interface ISaveLoadDoctors
    {
        void SaveDoctors(string path, List<IDoctor> doctors);
        List<IDoctor> LoadDoctors(string path);
    }

    public class DoctorsManager
    {
        public DoctorsManager(string path, ISaveLoadDoctors saveLoader)
        {
            Path = path;
            SaveLoader = saveLoader;
            Doctors = saveLoader.LoadDoctors(path);
        }

        public List<IDoctor> Doctors { get; set; }
        public string Path { get; }
        public ISaveLoadDoctors SaveLoader { get; }

        public void AddDoctor(IDoctor doctor)
        {
            Doctors.Add(doctor);
            SaveLoader.SaveDoctors(Path, Doctors);
        }

        public bool RemoveDoctor(IDoctor doctor)
        {
            var result = Doctors.Remove(doctor);
            if (!result) return false;
            SaveLoader.SaveDoctors(Path, Doctors);
            return true;
        }
    }

    //public class JsonSaveLoadDoctors : ISaveLoadDoctors
    //{
    //    public void SaveDoctors(string filePath, List<IDoctor> doctors)
    //    {
    //        File.WriteAllText(filePath, JsonSerializer.Serialize(doctors));
    //    }
    //    public List<IDoctor> LoadDoctors(string path)
    //    {

    //        if (File.Exists(path))
    //        {
    //            return JsonSerializer.Deserialize<List<IDoctor>>(File.ReadAllText(path));
    //        }
    //        File.Create(path).Close();
    //        var doctors = new List<IDoctor>();
    //        SaveDoctors(path, doctors);
    //        return doctors;
    //    }
    //}
}