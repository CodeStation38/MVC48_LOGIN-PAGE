namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedToNulls : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "HobbyId", c => c.Int());
            AlterColumn("dbo.Customers", "PreferredColorId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PreferredColorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "HobbyId", c => c.Int(nullable: false));
        }
    }
}
