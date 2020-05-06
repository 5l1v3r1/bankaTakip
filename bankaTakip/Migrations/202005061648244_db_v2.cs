namespace bankaTakip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db_v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectCategories",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        KategoriNo = c.Int(nullable: false),
                        ProjeNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.No)
                .ForeignKey("dbo.Projects", t => t.ProjeNo, cascadeDelete: true)
                .ForeignKey("dbo.ProjectForCategories", t => t.KategoriNo, cascadeDelete: true)
                .Index(t => t.KategoriNo)
                .Index(t => t.ProjeNo);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        ImageURL = c.String(unicode: false),
                        WebSiteURL = c.String(unicode: false),
                        Date = c.String(unicode: false),
                        createdDate = c.DateTime(nullable: false, precision: 0),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProjectForCategories",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        KategoriAdı = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(unicode: false),
                        TamamlandiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.No);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectCategories", "KategoriNo", "dbo.ProjectForCategories");
            DropForeignKey("dbo.ProjectCategories", "ProjeNo", "dbo.Projects");
            DropIndex("dbo.ProjectCategories", new[] { "ProjeNo" });
            DropIndex("dbo.ProjectCategories", new[] { "KategoriNo" });
            DropTable("dbo.Todoes");
            DropTable("dbo.ProjectForCategories");
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectCategories");
        }
    }
}
