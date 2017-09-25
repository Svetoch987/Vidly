namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredFKMovieImage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MovieImageId", "dbo.MovieImages");
            DropIndex("dbo.Movies", new[] { "MovieImageId" });
            AlterColumn("dbo.Movies", "MovieImageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "MovieImageId");
            AddForeignKey("dbo.Movies", "MovieImageId", "dbo.MovieImages", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieImageId", "dbo.MovieImages");
            DropIndex("dbo.Movies", new[] { "MovieImageId" });
            AlterColumn("dbo.Movies", "MovieImageId", c => c.Int());
            CreateIndex("dbo.Movies", "MovieImageId");
            AddForeignKey("dbo.Movies", "MovieImageId", "dbo.MovieImages", "Id");
        }
    }
}
