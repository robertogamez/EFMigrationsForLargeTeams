namespace Cintera.DAL
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public int InvestigationId { get; set; }
        public virtual Investigation Investigation { get; set; }

        public string VehicleIdentificationNumber { get; set; }
    }
}
