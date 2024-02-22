using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Suite.Models
{
    public class ProductTag
    {
        public DateTime AmendedTimestamp { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        [Key]
        public Guid Uid { get; set; }
        [ForeignKey("Product")]
        public Guid ProductUid { get; set; }
        public ProductModel Product { get; set; }
        [ForeignKey("Tag")]
        public Guid TagUid { get; set; }
        public TagModel Tag { get; set; }
    }
}