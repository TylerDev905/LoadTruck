using LoadTruckDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTruckDatabase
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()  : base("LoadTruckDb") 
        {
            // create the database and update it to the newest migration
            //Database.SetInitializer(new CreateDatabaseIfNotExists<DatabaseContext>());

            if (!Database.Exists())
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Migrations.Configuration>());
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // sets the validation of the entity model
            modelBuilder.Entity<Truck>()
                .Property(p => p.Name)
                .HasMaxLength(20)
                .IsRequired();
        }
        
        // Entity table mapping
        public DbSet<Truck>? Trucks { get; set; }
        public DbSet<TruckStatus>? TruckStatuses { get; set; }
        public DbSet<Box>? Boxs { get; set; }
        public DbSet<BoxStatus>? BoxStatuses { get; set; }
    }
}
