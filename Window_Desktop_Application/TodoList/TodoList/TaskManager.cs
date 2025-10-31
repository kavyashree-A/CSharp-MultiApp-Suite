using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class TaskManager
    {
        private const string FilePath = "Data/tasks.json";
        public List<Task> Tasks { get; set; }

        public TaskManager()
        {
            Tasks = new List<Task>();
            LoadTasks();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
            SaveTasks();
        }

        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
            SaveTasks();
        }

        public void SaveTasks()
        {
            Directory.CreateDirectory("Data");
            var json = JsonSerializer.Serialize(Tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public void LoadTasks()
        {
            if (!File.Exists(FilePath)) return;

            var json = File.ReadAllText(FilePath);
            Tasks = JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
        }
    }
}
