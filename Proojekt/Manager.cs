using projekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace projekt
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        List<T> GetAll();
        void SaveAll(List<T> items);
    }

    public class Manager<T> : IRepository<T>
    {
        public JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        private readonly string _filePath;  // Path to database
        public Manager(string filePath)
        {
            _filePath = filePath;
        }

        public void Add(T entity)
        {
            List<T> items = this.GetAll();
            if (!items.Contains(entity))
            {
                items.Add(entity);
                SaveAll(items);
            }
        }

        public void Remove(T item)
        {
            List<T> items = this.GetAll();
            if (items.Contains(item))
            {
                items.Remove(item); 
            }
            SaveAll(items);
        }

        public List<T> GetAll()
        {
            if (!File.Exists(_filePath)) return new List<T>();
            string jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(jsonString);
        }

        public void SaveAll(List<T> items)
        {
            string json = JsonSerializer.Serialize(items, options);
            File.WriteAllText(_filePath, json);
        }
    }
}
