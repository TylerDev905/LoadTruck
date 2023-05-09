namespace LoadTruckDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LoadTruckDatabase;
    using Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
            context.TruckStatuses.AddOrUpdate(ts => ts.TruckStatusId,
                new TruckStatus() { TruckStatusId = Guid.Parse("51b1886e-f8a5-4827-9549-8a00d89a2f7a"), Text = "Opened", Value = 'O' },
                new TruckStatus() { TruckStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662"), Text = "Closed", Value = 'C' });

            context.BoxStatuses.AddOrUpdate(bs => bs.BoxStatusId,
                new BoxStatus() { BoxStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662"), Text = "Inventory", Value = 'I' },
                new BoxStatus() { BoxStatusId = Guid.Parse("96526a0b-0ac1-4589-bbec-e0028f3f09f4"), Text = "Shipped", Value = 'S' });

            context.Trucks.AddOrUpdate(t => t.TruckId,
                new Truck() { TruckId = Guid.Parse("0e4aa9e9-679b-46c5-b27c-c9431640ef5d"), Name = "Truck 1", Number = 1, TruckStatusId = Guid.Parse("51b1886e-f8a5-4827-9549-8a00d89a2f7a") },
                new Truck() { TruckId = Guid.Parse("bbfbc646-5c8b-4534-bfea-a2942b7084ba"), Name = "Truck 2", Number = 2, TruckStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662") });

            context.Boxs.AddOrUpdate(b => b.BoxId,
                new Box() { BoxId = Guid.Parse("e7b432dc-a257-44ce-ad9c-2fa5bb33f57c"), Number = 1, Plu = "12345678", BoxStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662"), Weight = 1.1M, TruckId = null },
                new Box() { BoxId = Guid.Parse("ae47c2d4-beef-48b0-88bf-70a239159db4"), Number = 2, Plu = "12345678", BoxStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662"), Weight = 2.2M, TruckId = null },
                new Box() { BoxId = Guid.Parse("beb7743f-a6ef-4b72-90af-b98bb69c82d7"), Number = 3, Plu = "12345678", BoxStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662"), Weight = 2.3M, TruckId = null },
                new Box() { BoxId = Guid.Parse("2728159b-4d83-4b86-8113-08381b1af445"), Number = 4, Plu = "12345678", BoxStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662"), Weight = 1.5M, TruckId = Guid.Parse("0e4aa9e9-679b-46c5-b27c-c9431640ef5d") },
                new Box() { BoxId = Guid.Parse("8e47d303-73b4-4cd2-be9e-eb0ba83cf636"), Number = 5, Plu = "12345678", BoxStatusId = Guid.Parse("0ea9cf80-fb9d-4466-bdf2-9474ed08c662"), Weight = 2.5M, TruckId = Guid.Parse("bbfbc646-5c8b-4534-bfea-a2942b7084ba") });

            context.SaveChanges();
        }
    }
}
