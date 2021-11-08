namespace WebProducts.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        ProductName = c.String(),
                        Description = c.String(),
                        AvailableDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
        }
    }
}
