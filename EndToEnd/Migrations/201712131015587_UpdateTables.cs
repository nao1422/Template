namespace EndToEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SliderGallery", newName: "ImageSlider");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ImageSlider", newName: "SliderGallery");
        }
    }
}
