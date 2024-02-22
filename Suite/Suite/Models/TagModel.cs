namespace Suite.Models
{
    public class TagModel : BaseModel
    {
        public TagModel(string name)
        {
            Name = name;
        }
        
        public string Name { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
    }
}