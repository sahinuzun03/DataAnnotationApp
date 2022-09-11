namespace DataAnnotation2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ogretmen",
                c => new
                    {
                        OgretmenID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Yas = c.Int(nullable: false),
                        OkulID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgretmenID)
                .ForeignKey("dbo.Okuls", t => t.OkulID, cascadeDelete: true)
                .Index(t => t.OkulID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogretmen", "OkulID", "dbo.Okuls");
            DropIndex("dbo.Ogretmen", new[] { "OkulID" });
            DropTable("dbo.Ogretmen");
        }
    }
}
