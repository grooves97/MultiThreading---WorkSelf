using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TaskScheduler.Models
{
    public class Tasks : Entity
    {
        public string Filename { get; set; }
        public bool Execute { get; set; }
        public DateTime ExecutedTime { get; set; } = DateTime.Now;
    }
}
