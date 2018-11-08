namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeededDnaLabs : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO DnaLab(Name)
                VALUES ('Bode Cellmark Forensics'), ('Federal Bureau of Investigation Laboratory'), ('UNT Center for Human Identification')
            ");
        }

        public override void Down()
        {
            Sql(@"
                DELETE FROM DnaLab
                WHERE Name IN (
                    'Bode Cellmark Forensics', 'Federal Bureau of Investigation Laboratory', 'UNT Center for Human Identification'
                )
            ");
        }
    }
}
