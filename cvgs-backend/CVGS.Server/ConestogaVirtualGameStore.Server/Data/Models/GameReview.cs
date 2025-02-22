using System.ComponentModel.DataAnnotations;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class GameReview
    {
        [Key]
        public Guid ReviewID { get; set; }
        public string? MemberID { get; set; }
        public Guid GameID { get; set; }
        [Range(0, 5, ErrorMessage = "The rate shoud be in 0 -5 ")]
        public int Rating { get; set; } = 0;
        public string? ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool Approved { get; set; }

        public UserProfile? UserProfile { get; set; }  // Navigation property
        public Game? Game { get; set; }  // Navigation property
    }
}
