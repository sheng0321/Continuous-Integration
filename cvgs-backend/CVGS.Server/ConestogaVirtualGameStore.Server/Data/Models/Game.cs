using ConestogaVirtualGameStore.Server.Data.Enums;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string? GameName { get; set; }
        public string? Overview { get; set; }
        public string? ThumbnailPath { get; set; }
        public Guid GameCategoryId { get; set; }  // Foreign key
        public GameCategory? GameCategory { get; set; }  // Navigation property
        public Decimal? Price { get; set; }
        public int GamesInStock { get; set; } = 10;
        public bool IsDelete { get; set; } = false;
        public DateTime? UpdateTime { get; set; } = DateTime.Now;

        public ICollection<OrderDetail>? OrderDetails { get; set; } 
        public ICollection<GameReview>? GameReviews { get; set; }

        // Computed property to calculate the average rating
        public decimal Rate
        {
            get
            {
                if (GameReviews == null || !GameReviews.Any())
                {
                    return 3.0M;
                }
                return (decimal)GameReviews.Average(gr => gr.Rating);
            }
        }
    }

}
