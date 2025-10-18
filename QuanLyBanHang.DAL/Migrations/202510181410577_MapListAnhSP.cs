namespace QuanLyBanHang.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MapListAnhSP : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.ListAnhSPs",
                c => new
                    {
                        image_id = c.Int(nullable: false, identity: true),
                        product_id = c.Int(nullable: false),
                        image_url = c.String(),
                    })
                .PrimaryKey(t => t.image_id)
                .ForeignKey("dbo.Products", t => t.product_id, cascadeDelete: true)
                .Index(t => t.product_id);
           
            
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order_Items", "product_id", "dbo.Products");
            DropForeignKey("dbo.Orders", "user_id", "dbo.Users");
            DropForeignKey("dbo.Cart", "user_id", "dbo.Users");
            DropForeignKey("dbo.Order_Items", "order_id", "dbo.Orders");
            DropForeignKey("dbo.ListAnhSPs", "product_id", "dbo.Products");
            DropForeignKey("dbo.Cart", "product_id", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "user_id" });
            DropIndex("dbo.Order_Items", new[] { "product_id" });
            DropIndex("dbo.Order_Items", new[] { "order_id" });
            DropIndex("dbo.ListAnhSPs", new[] { "product_id" });
            DropIndex("dbo.Cart", new[] { "product_id" });
            DropIndex("dbo.Cart", new[] { "user_id" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Order_Items");
            DropTable("dbo.ListAnhSPs");
            DropTable("dbo.Products");
            DropTable("dbo.Cart");
        }
    }
}
