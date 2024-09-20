using System.Text.Json.Serialization;

namespace GroceryStore.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public int DayOfWeek { get; set; }
        public TimeOnly OpenTime { get; set; }
        public TimeOnly CloseTime { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public DateTime UpdateTimestamp { get; set; }

        [JsonIgnore]
        public Store Store { get; set; }
    }
}
