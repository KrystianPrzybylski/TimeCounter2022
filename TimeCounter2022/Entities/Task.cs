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
        DateTime Start { get; set; }  
        DateTime Stop { get; set; }


        public Task()
        {
            this.NameTask = "zad testowe1";
            this.CurrentTime = TimeSpan.Zero;
            this.TotalTime = TimeSpan.Zero; 
        }
        public void StartTime()
        {
            Start = DateTime.Now;     
        }

        public void StopTime()
        {
            Stop = DateTime.Now;
            CurrentTime = (Stop - Start).Duration();
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
