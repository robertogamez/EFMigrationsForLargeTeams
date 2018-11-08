namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRegion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(),
                        Name = c.String(nullable: false, maxLength: 255),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.RegionId)
                .ForeignKey("dbo.Region", t => t.ParentId)
                .Index(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Region", "ParentId", "dbo.Region");
            DropIndex("dbo.Region", new[] { "ParentId" });
            DropTable("dbo.Region");
        }
    }
}
