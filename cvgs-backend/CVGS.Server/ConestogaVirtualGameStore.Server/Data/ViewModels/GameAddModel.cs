using ConestogaVirtualGameStore.Server.Data.Enums;
using ConestogaVirtualGameStore.Server.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace ConestogaVirtualGameStore.Server.Data.ViewModels
{
    public class GameAddModel
    {
        [Required]
        public string? GameName { get; set; }

        [Required]
        public string? Overview { get; set; }

        [Required]
        public Decimal? Price { get; set; }

        [Required]
        public Guid GameCategoryId { get; set; }  // Use GameCategoryId instead of GameCategory

        [Required]
        public int GamesInStock { get; set; }

        public string? ThumbnailPath { get; set; }
    }

}
