namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DDLModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "HobbyId", c => c.Int(nullable: true));
            AlterColumn("dbo.Customers", "PreferredColorId", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PreferredColorId", c => c.Int());
            AlterColumn("dbo.Customers", "HobbyId", c => c.Int());
        }
    }
}
