namespace LoadTruckDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Box",
                c => new
                    {
                        BoxId = c.Guid(nullable: false),
                        Plu = c.String(),
                        Number = c.Int(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BoxStatusId = c.Guid(),
                        TruckId = c.Guid(),
                    })
                .PrimaryKey(t => t.BoxId)
                .ForeignKey("dbo.BoxStatus", t => t.BoxStatusId)
                .ForeignKey("dbo.Truck", t => t.TruckId)
                .Index(t => t.BoxStatusId)
                .Index(t => t.TruckId);
            
            CreateTable(
                "dbo.BoxStatus",
                c => new
                    {
                        BoxStatusId = c.Guid(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.BoxStatusId);
            
            CreateTable(
                "dbo.Truck",
                c => new
                    {
                        TruckId = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Number = c.Int(nullable: false),
                        TruckStatusId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.TruckId)
                .ForeignKey("dbo.TruckStatus", t => t.TruckStatusId, cascadeDelete: true)
                .Index(t => t.TruckStatusId);
            
            CreateTable(
                "dbo.TruckStatus",
                c => new
                    {
                        TruckStatusId = c.Guid(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.TruckStatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Truck", "TruckStatusId", "dbo.TruckStatus");
            DropForeignKey("dbo.Box", "TruckId", "dbo.Truck");
            DropForeignKey("dbo.Box", "BoxStatusId", "dbo.BoxStatus");
            DropIndex("dbo.Truck", new[] { "TruckStatusId" });
            DropIndex("dbo.Box", new[] { "TruckId" });
            DropIndex("dbo.Box", new[] { "BoxStatusId" });
            DropTable("dbo.TruckStatus");
            DropTable("dbo.Truck");
            DropTable("dbo.BoxStatus");
            DropTable("dbo.Box");
        }
    }
}
