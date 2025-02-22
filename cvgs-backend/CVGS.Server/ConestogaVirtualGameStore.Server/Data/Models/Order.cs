using Newtonsoft.Json;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class Order
    {
        public Guid OrderID { get; set; } = Guid.NewGuid();
        public string? MemberID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public string? Status { get; set; }
        [JsonIgnore]
        public UserProfile? UserProfile { get; set; }  // Navigation property
        public ICollection<OrderDetail>? OrderDetails { get; set; }  // Navigation property
    }
}
