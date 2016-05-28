namespace ClientsOrdersApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class g : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Orders");
            AddColumn("dbo.Orders", "Product_ProductId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Orders", "Status", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Orders", "OrderId");
            CreateIndex("dbo.Orders", "Product_ProductId");
            AddForeignKey("dbo.Orders", "Product_ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            DropColumn("dbo.Orders", "Product");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Product", c => c.String(nullable: false));
            DropForeignKey("dbo.Orders", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "Product_ProductId" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "Status", c => c.String());
            AlterColumn("dbo.Orders", "OrderId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Orders", "Product_ProductId");
            AddPrimaryKey("dbo.Orders", "OrderId");
        }
    }
}
