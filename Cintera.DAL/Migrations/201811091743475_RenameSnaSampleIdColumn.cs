namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RenameSnaSampleIdColumn : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DnaSample");
            RenameColumn("dbo.DnaSample", "Id", "DnaSampleId");
            AddPrimaryKey("dbo.DnaSample", "DnaSampleId");
        }

        public override void Down()
        {
            DropPrimaryKey("dbo.DnaSample");
            RenameColumn("dbo.DnaSample", "DnaSampleId", "Id");
            AddPrimaryKey("dbo.DnaSample", "Id");
        }
    }
}
