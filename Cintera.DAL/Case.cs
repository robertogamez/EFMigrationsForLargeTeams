using System.Collections.Generic;

namespace Cintera.DAL
{
    public class Investigation
    {
        public int InvestigationId { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
