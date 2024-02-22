namespace Suite.Models
{
    public class ProductModel : BaseModel
    {
        public ProductModel(string name)
        {
            Name = name;
        }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
    }
}
