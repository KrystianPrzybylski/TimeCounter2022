using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCounter2022.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string NameTask { get; set; }
        public TimeSpan CurrentTime { get; set; }
        public TimeSpan TotalTime { get; set; }

        public Task()
        {
            this.NameTask ="zad testowe"
        }

        public string GetAllTime
        {
            get 
            { 
                return $"{CurrentTime} {TotalTime}".ToString(); 
            }
        }
    }
}
