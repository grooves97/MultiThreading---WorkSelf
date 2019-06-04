using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace TaskScheduler.Models
{
    public class DirectoryTask : Tasks
    {
        public string FromPath { get; set; }
        public string ToPath { get; set; }

        public void DirectoryFolders()
        {
            if (!Directory.Exists(ToPath))
                Directory.CreateDirectory(ToPath);
            string[] files = Directory.GetFiles(FromPath);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(ToPath, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(FromPath);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(ToPath, name);
                DirectoryFolders();
            }
        }
    }
}
