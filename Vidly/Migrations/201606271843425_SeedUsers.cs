namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'070e5958-5956-4926-89dd-15481c3bbfa8', N'admin@vidly.com', 0, N'ANa6K9r2As0+YDhYNhpgwHsLraOC5Jd6KyNpdOB+F0qYqJjlSrPJuLeWvCOmDWVWMQ==', N'a851620a-8a6d-4c9e-b2d6-ce967d0cebcc', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ad5b6ce3-aa67-4138-bdc8-2eb1b17328f8', N'guest@vidly.com', 0, N'AJ2U/akGJvKS6gCSzN3QXdjbSEmU8T8az5M1gUfpdgbTGiZNctvqM8TRpTZrN94gew==', N'0b8261cf-291a-497c-a1b0-d7e405f534f3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5ee3e8ae-6266-4e4e-b75c-61a63f4f169e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'070e5958-5956-4926-89dd-15481c3bbfa8', N'5ee3e8ae-6266-4e4e-b75c-61a63f4f169e')

");
        }
        
        public override void Down()
        {
        }
    }
}
