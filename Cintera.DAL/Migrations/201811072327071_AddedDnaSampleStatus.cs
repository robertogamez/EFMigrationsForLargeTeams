namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDnaSampleStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DnaSampleStatus",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.DnaSample", "SampleStatusId");
            AddForeignKey("dbo.DnaSample", "SampleStatusId", "dbo.DnaSampleStatus", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DnaSample", "SampleStatusId", "dbo.DnaSampleStatus");
            DropIndex("dbo.DnaSample", new[] { "SampleStatusId" });
            DropTable("dbo.DnaSampleStatus");
        }
    }
}
