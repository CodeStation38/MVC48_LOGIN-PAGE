namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoIDforSearchColumns : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "HobbyId");
            DropColumn("dbo.Customers", "PreferredColorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PreferredColorId", c => c.Int());
            AddColumn("dbo.Customers", "HobbyId", c => c.Int());
        }
    }
}
