namespace bankaTakip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        HesapAdi = c.String(unicode: false),
                        HesapNo = c.Int(nullable: false),
                        HesapEkNo = c.Int(nullable: false),
                        AcilisBakiyesi = c.Double(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        VarsayılanHesapMi = c.Boolean(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false, precision: 0),
                        GuncellemeTarihi = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.BranchAccounts",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        SubeNo = c.Int(nullable: false),
                        HesapNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.No)
                .ForeignKey("dbo.Accounts", t => t.HesapNo, cascadeDelete: true)
                .ForeignKey("dbo.Branches", t => t.SubeNo, cascadeDelete: true)
                .Index(t => t.SubeNo)
                .Index(t => t.HesapNo);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        BankaNo = c.Int(nullable: false),
                        SubeAdi = c.String(unicode: false),
                        SubeKodu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.No)
                .ForeignKey("dbo.Banks", t => t.BankaNo, cascadeDelete: true)
                .Index(t => t.BankaNo);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        BankaAdi = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.BankCards",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        BankaNo = c.Int(nullable: false),
                        CardNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.No)
                .ForeignKey("dbo.Banks", t => t.BankaNo, cascadeDelete: true)
                .ForeignKey("dbo.Cards", t => t.CardNo, cascadeDelete: true)
                .Index(t => t.BankaNo)
                .Index(t => t.CardNo);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        KartNo = c.String(maxLength: 19, storeType: "nvarchar"),
                        SonKullanmaTarihi = c.Int(nullable: false),
                        CVCKodu = c.Int(nullable: false),
                        KartOdemeYontemi = c.Int(nullable: false),
                        KartTipi = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        HesapKesimGunu = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.BankCredits",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        BankaNo = c.Int(nullable: false),
                        CreditNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.No)
                .ForeignKey("dbo.Banks", t => t.BankaNo, cascadeDelete: true)
                .ForeignKey("dbo.Credits", t => t.CreditNo, cascadeDelete: true)
                .Index(t => t.BankaNo)
                .Index(t => t.CreditNo);
            
            CreateTable(
                "dbo.Credits",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        CekilenTutar = c.Double(nullable: false),
                        YapilanTaksit = c.Int(nullable: false),
                        CekilmeTarihi = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        HesapNo = c.Int(nullable: false),
                        IslemTarihi = c.DateTime(nullable: false, precision: 0),
                        Tutar = c.Double(nullable: false),
                        Aciklama = c.String(unicode: false),
                        KategoriNo = c.Int(nullable: false),
                        OdemeTipi = c.Int(nullable: false),
                        DokumanYolu = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.No)
                .ForeignKey("dbo.Accounts", t => t.HesapNo, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.KategoriNo, cascadeDelete: true)
                .Index(t => t.HesapNo)
                .Index(t => t.KategoriNo);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.Transfers",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        HesapNo = c.Int(nullable: false),
                        MusteriNo = c.Int(nullable: false),
                        Tutar = c.Double(nullable: false),
                        IslemTarihi = c.DateTime(nullable: false, precision: 0),
                        Aciklama = c.String(unicode: false),
                        OdemeTipi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.No)
                .ForeignKey("dbo.Accounts", t => t.HesapNo, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.MusteriNo, cascadeDelete: true)
                .Index(t => t.HesapNo)
                .Index(t => t.MusteriNo);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        Adi = c.String(unicode: false),
                        Soyadi = c.String(unicode: false),
                        IBAN = c.String(unicode: false),
                        Telefon = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.Definitions",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        TanımAdı = c.String(unicode: false),
                        Icerik = c.String(unicode: false),
                        Aciklama = c.String(unicode: false),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.ProjectStatus",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(unicode: false),
                        TamamlandiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        MailAdresi = c.String(unicode: false),
                        Telefon = c.String(unicode: false),
                        LogoYolu = c.String(unicode: false),
                        FaviconYolu = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, unicode: false),
                        Soyadi = c.String(nullable: false, unicode: false),
                        MailAdresi = c.String(nullable: false, unicode: false),
                        Sifre = c.String(nullable: false, unicode: false),
                        SifreTekrar = c.String(unicode: false),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.No);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transfers", "MusteriNo", "dbo.Customers");
            DropForeignKey("dbo.Transfers", "HesapNo", "dbo.Accounts");
            DropForeignKey("dbo.Transactions", "KategoriNo", "dbo.Categories");
            DropForeignKey("dbo.Transactions", "HesapNo", "dbo.Accounts");
            DropForeignKey("dbo.BranchAccounts", "SubeNo", "dbo.Branches");
            DropForeignKey("dbo.Branches", "BankaNo", "dbo.Banks");
            DropForeignKey("dbo.BankCredits", "CreditNo", "dbo.Credits");
            DropForeignKey("dbo.BankCredits", "BankaNo", "dbo.Banks");
            DropForeignKey("dbo.BankCards", "CardNo", "dbo.Cards");
            DropForeignKey("dbo.BankCards", "BankaNo", "dbo.Banks");
            DropForeignKey("dbo.BranchAccounts", "HesapNo", "dbo.Accounts");
            DropIndex("dbo.Transfers", new[] { "MusteriNo" });
            DropIndex("dbo.Transfers", new[] { "HesapNo" });
            DropIndex("dbo.Transactions", new[] { "KategoriNo" });
            DropIndex("dbo.Transactions", new[] { "HesapNo" });
            DropIndex("dbo.BankCredits", new[] { "CreditNo" });
            DropIndex("dbo.BankCredits", new[] { "BankaNo" });
            DropIndex("dbo.BankCards", new[] { "CardNo" });
            DropIndex("dbo.BankCards", new[] { "BankaNo" });
            DropIndex("dbo.Branches", new[] { "BankaNo" });
            DropIndex("dbo.BranchAccounts", new[] { "HesapNo" });
            DropIndex("dbo.BranchAccounts", new[] { "SubeNo" });
            DropTable("dbo.Users");
            DropTable("dbo.Settings");
            DropTable("dbo.ProjectStatus");
            DropTable("dbo.Definitions");
            DropTable("dbo.Customers");
            DropTable("dbo.Transfers");
            DropTable("dbo.Categories");
            DropTable("dbo.Transactions");
            DropTable("dbo.Credits");
            DropTable("dbo.BankCredits");
            DropTable("dbo.Cards");
            DropTable("dbo.BankCards");
            DropTable("dbo.Banks");
            DropTable("dbo.Branches");
            DropTable("dbo.BranchAccounts");
            DropTable("dbo.Accounts");
        }
    }
}
