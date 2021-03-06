namespace ClientsOrdersApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gk3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "Client_ClientId", newName: "ClientId");
            RenameIndex(table: "dbo.Orders", name: "IX_Client_ClientId", newName: "IX_ClientId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_ClientId", newName: "IX_Client_ClientId");
            RenameColumn(table: "dbo.Orders", name: "ClientId", newName: "Client_ClientId");
        }
    }
}
