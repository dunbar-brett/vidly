namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PendingModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "AmountInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "AmountInStock", c => c.Short(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
