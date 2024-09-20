namespace GroceryStore.Entities
{
    public class ProductStore
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }
        public float Price { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public DateTime UpdateTimestamp { get; set; }
    }
}
