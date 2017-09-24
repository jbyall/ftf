namespace FTF.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuadrantCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserItems", "Quadrant", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserItems", "Quadrant");
        }
    }
}
