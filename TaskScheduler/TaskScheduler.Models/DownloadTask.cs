using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler.Models
{
    public class DownloadTask
    {
        public string From { get; set; }
        public string To { get; set; }

        public bool Execute()
        {
            throw new NotImplementedException();
        }
    }
}
