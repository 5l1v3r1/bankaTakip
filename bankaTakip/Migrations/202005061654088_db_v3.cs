namespace bankaTakip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db_v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Cinsiyet", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Cinsiyet");
        }
    }
}
