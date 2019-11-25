namespace CanineKinship.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "Month", c => c.String());
            AddColumn("dbo.Notifications", "Day", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifications", "Day");
            DropColumn("dbo.Notifications", "Month");
        }
    }
}
