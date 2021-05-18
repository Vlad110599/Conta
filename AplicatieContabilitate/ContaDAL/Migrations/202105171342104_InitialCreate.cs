namespace ContaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Point1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Venituri = c.Double(nullable: false),
                        Cheltuieli = c.Double(nullable: false),
                        Profit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Point2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Venituri = c.Double(nullable: false),
                        Cheltuieli = c.Double(nullable: false),
                        Profit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Point3",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Venituri = c.Double(nullable: false),
                        Cheltuieli = c.Double(nullable: false),
                        Profit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Point4",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Venituri = c.Double(nullable: false),
                        Cheltuieli = c.Double(nullable: false),
                        Profit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Point5",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Venituri = c.Double(nullable: false),
                        Cheltuieli = c.Double(nullable: false),
                        Profit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Point6",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Venituri = c.Double(nullable: false),
                        Cheltuieli = c.Double(nullable: false),
                        Profit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Utilizator",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 30),
                        Password = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilizator");
            DropTable("dbo.Point6");
            DropTable("dbo.Point5");
            DropTable("dbo.Point4");
            DropTable("dbo.Point3");
            DropTable("dbo.Point2");
            DropTable("dbo.Point1");
        }
    }
}
