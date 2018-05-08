namespace DocTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Docs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        DocNumber = c.String(),
                        ReceiveDate = c.DateTime(nullable: false),
                        SendDate = c.DateTime(nullable: false),
                        YearNumber = c.Int(nullable: false),
                        SecretLv = c.Int(nullable: false),
                        Copies = c.Int(nullable: false),
                        Scope = c.String(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Opers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DocID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Docs", t => t.DocID, cascadeDelete: true)
                .Index(t => t.DocID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Opers", "DocID", "dbo.Docs");
            DropIndex("dbo.Opers", new[] { "DocID" });
            DropTable("dbo.Opers");
            DropTable("dbo.Docs");
        }
    }
}
