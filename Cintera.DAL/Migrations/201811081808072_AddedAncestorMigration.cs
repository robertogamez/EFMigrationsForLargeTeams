namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedAncestorMigration : DbMigration
    {
        public override void Up()
        {
            Sql(Scripts.V_AncestorRegion);

        }

        public override void Down()
        {
            Sql("DROP VIEW V_AncestorRegion");
        }
    }
}
