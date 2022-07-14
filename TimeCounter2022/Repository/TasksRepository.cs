using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCounter2022.Repository
{
    using TimeCounter2022.Entities;
    public class TasksRepository
    {
        private readonly List<Task> _tasks = new List<Task>();  

        public void Add(Task task)
        {
            task.Id = _tasks.Count + 1;
            _tasks.Add(task);
        }

        public void Save()
        { }

        public Task GetById(int id)
        {
            return _tasks.Single(item=>item.Id == id);
        }


    }
}
