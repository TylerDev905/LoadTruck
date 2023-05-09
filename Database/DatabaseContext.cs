using Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()  : base("LoadTruckDb") 
        {
            Console.WriteLine();
        }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Box> Boxs { get; set; }
    }
}
