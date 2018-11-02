namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        CaseId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CaseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cases");
        }
    }
}
