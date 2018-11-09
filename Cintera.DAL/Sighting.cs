using System;

namespace Cintera.DAL
{
    public class Sighting
    {
        public int SightingId { get; set; }

        public int InvestigationId { get; set; }
        public virtual Investigation Investigation { get; set; }

        public string Address { get; set; }
        public DateTime Date { get; set; }
    }
}
