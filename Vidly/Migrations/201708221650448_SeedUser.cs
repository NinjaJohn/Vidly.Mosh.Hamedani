namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
         Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19b5898f-057f-4d1f-80f8-04eee67991e9', N'john.lundberg@svemo.se', 0, N'ADBi4T61P21OOPq7YnNI5/Xrc5hl92440cmH+NgkmDBApuKYiI8Cvb/meM2dfphwfA==', N'71e3b851-cad1-4df7-ab2d-155bdaa4f59f', NULL, 0, 0, NULL, 1, 0, N'john.lundberg@svemo.se')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b51f5e8-d1ef-4a63-956b-3bd8be475fb7', N'manager@vidly.com', 0, N'AOWolbJ/1xhtSGxNcOaPCRxFBGDZvu1WuBubkXGOcMnJpipMv86+ianJ+sQtkkRJrA==', N'b0b8577b-ba0b-4f90-b61c-5c4842adbfea', NULL, 0, 0, NULL, 1, 0, N'manager@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ddeed3df-96c3-4abf-9b13-a962506d28db', N'management@vidly.com', 0, N'ADowUlWBuA450kjjMJ6H9cJM+KBCCCx96wMO9yAEK6YjANq4Xr6vFiwyvuiZRZy+RQ==', N'1076ca52-71cf-4789-b780-bbafa6902625', NULL, 0, 0, NULL, 1, 0, N'management@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'659c636b-9a40-41c9-a2f5-ec11847f2c34', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9b51f5e8-d1ef-4a63-956b-3bd8be475fb7', N'659c636b-9a40-41c9-a2f5-ec11847f2c34')


");
        }
        
        public override void Down()
        {
        }
    }
}
