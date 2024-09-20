namespace GroceryStore.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Place { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public DateTime UpdateTimestamp { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<ProductStore> ProductStore { get; set; }
    }
}
