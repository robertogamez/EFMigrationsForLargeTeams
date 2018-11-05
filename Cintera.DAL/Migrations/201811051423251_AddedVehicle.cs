namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVehicle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        CaseId = c.Int(nullable: false),
                        VehicleIdentificationNumber = c.String(nullable: false, maxLength: 17),
                    })
                .PrimaryKey(t => t.VehicleId)
                .ForeignKey("dbo.Case", t => t.CaseId, cascadeDelete: true)
                .Index(t => t.CaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "CaseId", "dbo.Case");
            DropIndex("dbo.Vehicle", new[] { "CaseId" });
            DropTable("dbo.Vehicle");
        }
    }
}
