namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeededRegions : DbMigration
    {
        public override void Up()
        {
            Sql(Scripts.CountryByState);
            Sql(Scripts.InsertRegions);
        }

        public override void Down()
        {
            Sql("DELETE FROM Region");
        }
    }
}
