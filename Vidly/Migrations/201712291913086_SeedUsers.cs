namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'665a4adb-1982-4def-93fc-e303e05d8170', N'guest@vidly.com', 0, N'ANiv4v9yLPiJ7ltIsBACU8b3HMSlCBvXPCHSPGpLuvX59TGAAaIChE23V19auEBj8Q==', N'0e2d5e8f-8021-4ede-92e1-828018fbcf70', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8c7eb4a2-2344-4740-9ee2-c7d76a4c8628', N'admin@vidly.com', 0, N'ALxKvfFgf67OmpO17tEO5Qhw9KyAOf34ieXCk+sSv7CAa1jfA+5qenUrd+Ufsru30w==', N'4d62b0e9-9079-4a4b-8dd1-74677383c5ba', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1e18a0ab-52a8-450e-8ada-38b80694f43e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8c7eb4a2-2344-4740-9ee2-c7d76a4c8628', N'1e18a0ab-52a8-450e-8ada-38b80694f43e')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
