namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RenameCaseToInvestigation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicle", "CaseId", "dbo.Case");
            DropIndex("dbo.Vehicle", new[] { "CaseId" });

            DropPrimaryKey("dbo.Case");
            RenameColumn("dbo.Case", "CaseId", "InvestigationId");
            RenameTable("dbo.Case", "Investigation");
            AddPrimaryKey("dbo.Investigation", "InvestigationId");

            RenameColumn("dbo.Vehicle", "CaseId", "InvestigationId");
            CreateIndex("dbo.Vehicle", "InvestigationId");
            AddForeignKey("dbo.Vehicle", "InvestigationId", "dbo.Investigation", "InvestigationId");

        }

        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "InvestigationId", "dbo.Investigation");
            DropIndex("dbo.Vehicle", new[] { "InvestigationId" });

            DropPrimaryKey("dbo.Investigation");
            RenameColumn("dbo.Investigation", "InvestigationId", "CaseId");

            RenameTable("dbo.Investigation", "Case");
            AddPrimaryKey("dbo.Case", "CaseId");

            RenameColumn("dbo.Vehicle", "InvestigationId", "CaseId");
            CreateIndex("dbo.Vehicle", "CaseId");

            AddForeignKey("dbo.Vehicle", "CaseId", "dbo.Case", "CaseId", cascadeDelete: true);
        }
    }
}
