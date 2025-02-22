using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class EventRegister
    {
        public Guid Id { get; set; }
        [Required]
        public Guid? EventId { get; set; }
        [Required]
        public string? MemberId { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? CancelTime; 

        public bool IsCancel { get; set; } = false;

        public CvgsEvent? Event { get; set; }  // Navigation property nullable updated by lxd
        public UserProfile? UserProfile { get; set; }  // Navigation property nullable updated by lxd
    }
}
