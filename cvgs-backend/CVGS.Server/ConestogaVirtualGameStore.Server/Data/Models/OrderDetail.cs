using System.ComponentModel.DataAnnotations;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class OrderDetail
    {
        public Guid OrderDetailID { get; set; } = Guid.NewGuid();
        public Guid OrderID { get; set; }
        public Guid GameID { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal Price { get; set; }

        public Order? Order { get; set; }  // Navigation property
        public Game? Game { get; set; }    // Navigation property
    }
}
