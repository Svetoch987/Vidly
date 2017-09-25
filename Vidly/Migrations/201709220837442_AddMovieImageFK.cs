namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieImageFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieImageId", c => c.Int());
            CreateIndex("dbo.Movies", "MovieImageId");
            AddForeignKey("dbo.Movies", "MovieImageId", "dbo.MovieImages", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieImageId", "dbo.MovieImages");
            DropIndex("dbo.Movies", new[] { "MovieImageId" });
            DropColumn("dbo.Movies", "MovieImageId");
        }
    }
}
