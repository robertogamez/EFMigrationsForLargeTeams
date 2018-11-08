namespace Cintera.DAL
{
    public class Region
    {
        public int RegionId { get; set; }

        public int? ParentId { get; set; }
        public virtual Region Parent { get; set; }

        public string Name { get; set; }
    }

    public class Country : Region { }
    public class State : Region { }
    public class County : Region { }
}
