namespace Hamburger_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intToDecimalForPrice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Extras", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Orders", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Menus", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Extras", "Price", c => c.Int(nullable: false));
        }
    }
}
