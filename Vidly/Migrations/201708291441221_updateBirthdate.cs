namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class updateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = Null Where Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
