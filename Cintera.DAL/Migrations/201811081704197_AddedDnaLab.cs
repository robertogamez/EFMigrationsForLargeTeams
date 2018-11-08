namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDnaLab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DnaLab",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DnaSample", "DnaLabId", c => c.Int(nullable: false));
            CreateIndex("dbo.DnaSample", "DnaLabId");
            AddForeignKey("dbo.DnaSample", "DnaLabId", "dbo.DnaLab", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DnaSample", "DnaLabId", "dbo.DnaLab");
            DropIndex("dbo.DnaSample", new[] { "DnaLabId" });
            DropColumn("dbo.DnaSample", "DnaLabId");
            DropTable("dbo.DnaLab");
        }
    }
}
