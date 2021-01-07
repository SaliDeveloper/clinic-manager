using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FinalProject.Main_Classes.Controllers
{
    public interface ISaveLoadData<T>
    {
        void SaveData(string path, List<T> items);
        List<T> LoadData(string path);
    }

    public class DataManager<T>
    {
        public DataManager(string filePath, ISaveLoadData<T> saveLoader)
        {
            FilePath = filePath;
            SaveLoader = saveLoader;
            Items = saveLoader.LoadData(filePath);
        }

        public List<T> Items { get; set; }
        public string FilePath { get; }
        public ISaveLoadData<T> SaveLoader { get; }

        public void AddItem(T item)
        {
            Items.Add(item);
        }

        public bool RemoveItem(T item)
        {
            return Items.Remove(item);
        }

        public void NotifyDataSetChange(List<T> items = null)
        {
            if (items != null)
            {
                Items = items;
            }
            SaveLoader.SaveData(FilePath, Items);
        }

        ~DataManager()
        {
            SaveLoader.SaveData(FilePath, Items);
        }
    }

    public class JsonSaveLoadData<T> : ISaveLoadData<T>
    {
        public void SaveData(string filePath, List<T> items)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(items));
        }
        public List<T> LoadData(string path)
        {
            if (File.Exists(path))
            {
                return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
            }
            File.Create(path).Close();
            var items = new List<T>();
            SaveData(path, items);
            return items;
        }
    }
}
