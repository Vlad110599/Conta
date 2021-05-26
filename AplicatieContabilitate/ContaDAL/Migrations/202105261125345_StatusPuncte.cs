namespace ContaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusPuncte : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Point1", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Point2", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Point3", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Point4", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Point5", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Point6", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Point6", "Status");
            DropColumn("dbo.Point5", "Status");
            DropColumn("dbo.Point4", "Status");
            DropColumn("dbo.Point3", "Status");
            DropColumn("dbo.Point2", "Status");
            DropColumn("dbo.Point1", "Status");
        }
    }
}
