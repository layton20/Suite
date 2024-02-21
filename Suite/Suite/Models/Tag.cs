namespace Suite.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid Uid { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public DateTime AmendedTimestamp { get; set; }
    }
}
