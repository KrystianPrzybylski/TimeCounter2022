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
        public DateTime CurrentTime { get; set; }
        public DateTime TotalTime { get; set; }

        public string GetAllTime
        {
            get 
            { 
                return $"{CurrentTime} {TotalTime}".ToString(); 
            }
        }
    }
}
