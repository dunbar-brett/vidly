namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET GenreName = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET GenreName = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET GenreName = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET GenreName = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
