using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class Task
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public Task() { }

        public Task(string title)
        {
            Title = title;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return IsCompleted ? $"✅ {Title}" : $"📝 {Title}";
        }
    }
}
