using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TaskScheduler.Models;

namespace TaskScheduler.DataAcces
{
    public class DataContext : DbContext
    {
        public DataContext():base("name=DataContext")
        {

        }

        public DbSet<DownloadTask> DownloadTask { get; set; }
    }
}
