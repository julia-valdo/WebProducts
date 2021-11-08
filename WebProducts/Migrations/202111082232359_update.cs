namespace WebProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "Category", c => c.String(maxLength: 150));
            AlterColumn("dbo.Product", "ProductName", c => c.String(maxLength: 150));
            AlterColumn("dbo.Product", "Description", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "Description", c => c.String());
            AlterColumn("dbo.Product", "ProductName", c => c.String());
            AlterColumn("dbo.Product", "Category", c => c.String());
        }
    }
}
