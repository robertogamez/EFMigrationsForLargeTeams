namespace Cintera.DAL
{
    public class DnaSample
    {
        public int DnaSampleId { get; set; }
        public DnaSampleStatusEnum SampleStatusId { get; set; }
        public virtual DnaSampleStatus SampleStatus { get; set; }

        public int DnaLabId { get; set; }
        public virtual DnaLab DnaLab { get; set; }
    }
}
