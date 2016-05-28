namespace ClientsOrdersApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FFF : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Birthday", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
