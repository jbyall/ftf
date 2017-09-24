namespace FTF.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserItemCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserItems", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserItems", new[] { "UserId" });
            DropTable("dbo.UserItems");
        }
    }
}
