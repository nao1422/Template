namespace EndToEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Content",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 200),
                        Image = c.Binary(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Newsletter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Newsletter", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.News", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Content", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Newsletter", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.News", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Content", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Newsletter");
            DropTable("dbo.News");
            DropTable("dbo.Content");
        }
    }
}
