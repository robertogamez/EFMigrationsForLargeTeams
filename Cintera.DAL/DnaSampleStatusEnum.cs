namespace Cintera.DAL
{
    public enum DnaSampleStatusEnum
    {
        Available = 0,
        Collected = 1,
        Submitted = 2,
        Profiled = 3,
        NoResult = 4
    }

    public class DnaSampleStatus
    {
        public DnaSampleStatusEnum Id { get; set; }
        public string Name { get; set; }
    }
}