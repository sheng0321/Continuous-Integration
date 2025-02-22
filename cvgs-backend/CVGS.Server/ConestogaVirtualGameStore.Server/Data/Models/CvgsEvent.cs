using System.ComponentModel.DataAnnotations;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class CvgsEvent
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? EventName { get; set; }

        public string? EventDescription { get; set; }
        [Required]

        public DateTime EventDateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public bool IsDeleted { get; set; } = false;

        public ICollection<EventRegister>? EventRegisters { get; set; }  // Navigation property

    }
}
