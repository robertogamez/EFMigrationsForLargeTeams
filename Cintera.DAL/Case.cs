using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cintera.DAL
{
    public class Case
    {
        public int CaseId { get; set; }

        public virtual ICollection<Sighting> Sightings { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
