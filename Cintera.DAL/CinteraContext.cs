using System.Data.Entity;

namespace Cintera.DAL
{
    public class CinteraContext : DbContext
    {
        public CinteraContext()
            : base("CinteraContext")
        {

        }
    }
}
