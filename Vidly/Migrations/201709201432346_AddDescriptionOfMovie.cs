namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionOfMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Description");
        }
    }
}
