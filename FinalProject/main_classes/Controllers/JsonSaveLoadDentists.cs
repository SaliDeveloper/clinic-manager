using FinalProject.Interfaces;
using FinalProject.Main_Classes.Dental_Specialties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FinalProject.Main_Classes.Controllers
{
    public class JsonSaveLoadDentists : ISaveLoadDoctors
    {
        public void SaveDoctors(string filePath, List<IDoctor> doctors)
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(doctors));
        }
        public List<IDoctor> LoadDoctors(string path)
        {
            var doctors = new List<IDoctor>();
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var jArray = JArray.Parse(json);
                foreach (var jToken in jArray)
                {
                    var attendances = jToken["Attendances"].ToObject<List<DayOfWeek>>();
                    var jProfile = jToken["Profile"];
                    var profile = new Profile(
                        jProfile["FirstName"].ToObject<string>(),
                        jProfile["LastName"].ToObject<string>(),
                        jProfile["NationalCode"].ToObject<string>(),
                        jProfile["Gender"].ToObject<Gender>()
                    );
                    IDoctor doctor = jToken["Type"].ToObject<string>() switch
                    {
                        "Endodontics" => new Endodontics(profile, null, attendances),
                        "Orthodontics" => new Orthodontics(profile, null, attendances),
                        "PediatricDentistry" => new PediatricDentistry(profile, null, attendances),
                        "Periodontics" => new Periodontics(profile, null, attendances),
                        "Prosthodontics" => new Prosthodontics(profile, null, attendances),
                        "RestorativeDentistry" => new RestorativeDentistry(profile, null, attendances),
                        _ => null
                    };
                    if (doctor != null)
                        doctors.Add(doctor);
                }
                return doctors;
            }
            else
            {
                File.Create(path).Close();
                SaveDoctors(path, doctors);
            }
            return doctors;
        }

    }
}