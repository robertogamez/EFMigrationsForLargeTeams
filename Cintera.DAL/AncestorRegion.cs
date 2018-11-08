namespace Cintera.DAL
{
    public class AncestorRegion
    {
        public int RegionId { get; set; }
        public int AncestorRegionId { get; set; }
        public virtual Region AncestorRegionRef { get; set; }
    }
}
