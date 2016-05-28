namespace ClientsOrdersApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hhh1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "Product_ProductId", newName: "ProductId");
            RenameIndex(table: "dbo.Orders", name: "IX_Product_ProductId", newName: "IX_ProductId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_ProductId", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Orders", name: "ProductId", newName: "Product_ProductId");
        }
    }
}
