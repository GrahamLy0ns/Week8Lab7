namespace Week8Lab7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHomeGround : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "HomeGround", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "HomeGround");
        }
    }
}
