namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDnaSample : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DnaSample",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SampleStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DnaSample");
        }
    }
}
