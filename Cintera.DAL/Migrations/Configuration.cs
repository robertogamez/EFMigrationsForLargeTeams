namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cintera.DAL.CinteraContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cintera.DAL.CinteraContext context)
        {
            context.DnaSampleStatus.AddOrUpdate(
                x => x.Id,
                Enum.GetValues(typeof(DnaSampleStatusEnum)).OfType<DnaSampleStatusEnum>()
                    .Select(x => new DnaSampleStatus
                    {
                        Id = x,
                        Name = x.ToString()
                    }).ToArray()
            );
        }
    }
}
