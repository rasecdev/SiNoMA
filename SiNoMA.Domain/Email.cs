namespace SiNoMA.Domain
{
    public class Email
    {
        public long ID { get; set; }
        public string DescricaoEmail { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
