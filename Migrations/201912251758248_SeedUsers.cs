namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2ed1dce9-b662-41f3-87b8-9a24bf07e9ed', N'guest@vidly.com', 0, N'ANJIGUydJB2bg6r3b0abuYTHNsAPvz/GMSjMKklGMUuc1Tt5vk2YMdtTovhf6fNYDQ==', N'bbe480c3-36c9-4694-977c-8be7440e261e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a039e5d6-1dd0-4916-aece-148cc259ab82', N'admin@vidly.com', 0, N'AB50wv8DESDoHuDjPXnxC33zN6Axn3eb2gZI3Gz5gxiO/ZOLStPrWu0qz9sXvJPiqA==', N'9c9ebfab-a8f9-482b-a69a-d8a4a69a432d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'287c192b-02e3-48aa-8cf6-fa11b3cda986', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a039e5d6-1dd0-4916-aece-148cc259ab82', N'287c192b-02e3-48aa-8cf6-fa11b3cda986')
");
        }
        
        public override void Down()
        {
        }
    }
}
