namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrders1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.OrderItems", "Prise");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "Prise", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.OrderItems", "Price");
        }
    }
}
