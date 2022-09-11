namespace DataAnnotation2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sınıf",
                c => new
                    {
                        SınıfID = c.Int(nullable: false, identity: true),
                        SıraSayısı = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SınıfID);
            
            CreateTable(
                "dbo.SınıfOgretmen",
                c => new
                    {
                        Sınıf_SınıfID = c.Int(nullable: false),
                        Ogretmen_OgretmenID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sınıf_SınıfID, t.Ogretmen_OgretmenID })
                .ForeignKey("dbo.Sınıf", t => t.Sınıf_SınıfID, cascadeDelete: true)
                .ForeignKey("dbo.Ogretmen", t => t.Ogretmen_OgretmenID, cascadeDelete: true)
                .Index(t => t.Sınıf_SınıfID)
                .Index(t => t.Ogretmen_OgretmenID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SınıfOgretmen", "Ogretmen_OgretmenID", "dbo.Ogretmen");
            DropForeignKey("dbo.SınıfOgretmen", "Sınıf_SınıfID", "dbo.Sınıf");
            DropIndex("dbo.SınıfOgretmen", new[] { "Ogretmen_OgretmenID" });
            DropIndex("dbo.SınıfOgretmen", new[] { "Sınıf_SınıfID" });
            DropTable("dbo.SınıfOgretmen");
            DropTable("dbo.Sınıf");
        }
    }
}
