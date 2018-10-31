using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cintera.DAL
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public int CaseId { get; set; }
        public virtual Case Case { get; set; }

        public string VehicleIdentificationNumber { get; set; }
    }
}
