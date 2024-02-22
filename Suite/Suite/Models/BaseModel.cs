using System.ComponentModel.DataAnnotations;

namespace Suite.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            AmendedTimestamp = DateTime.Now;
            CreatedTimestamp = DateTime.Now;
            Uid = Guid.NewGuid();
        }
        
        public DateTime AmendedTimestamp { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public int Id { get; set; }
        [Key]
        public Guid Uid { get; set; }
    }
}