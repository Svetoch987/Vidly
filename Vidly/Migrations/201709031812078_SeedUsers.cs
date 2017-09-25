namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9dfe7f97-a21e-48ca-8b46-a0b7d16bf832', N'guest@vidly.com', 0, N'AOkfJplstx5LDtZMPF15zwWjs3q1K/KyHZ53H9wLoADoMJa76j12+w1gwMnS77n6PQ==', N'5d322b1a-e526-487b-8fed-deb1230e24d8', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'ce32e450-a140-452f-86e9-46a8fbb6e841', N'admin@vidly.com', 0, N'AKXREq3GGXQ1BvpJCa5uoiaVrC0CTh3YKTbXGSaLSNrjpnBP0K52Xrw7n697AV66Qw==', N'01066fb5-14b6-47f0-8551-de6091c434ae', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7e905a85-0f7b-4834-843b-a4204ee7db5a', N'Administrator')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ce32e450-a140-452f-86e9-46a8fbb6e841', N'7e905a85-0f7b-4834-843b-a4204ee7db5a')");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
