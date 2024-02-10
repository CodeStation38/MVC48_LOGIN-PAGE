namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DDL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "HobbyId", c => c.Int());
            AddColumn("dbo.Customers", "PreferredColorId", c => c.Int());
            AddColumn("dbo.Customers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Discriminator");
            DropColumn("dbo.Customers", "PreferredColorId");
            DropColumn("dbo.Customers", "HobbyId");
        }
    }
}
