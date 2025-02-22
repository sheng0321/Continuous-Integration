using Microsoft.CodeAnalysis;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class MemberPreference
    {
        public Guid Id { get; set; }
        public string MemberId { get; set; }
        public Guid PlatformId { get; set; }
        public FavoritePlatform? FavoritePlatform { get; set; } // Navigation property nullable by lxd

        public Guid GameCategoryId { get; set; }
        public GameCategory? FavoriteGameCategory { get; set; } // Navigation property nullable lxd

        public Guid LanguageId { get; set; } // Foreign key for Language
        public Language? LanguagePreference { get; set; } // Navigation property nullable lxd

        public DateTime UpdateTime { get; set; } // Last update time 
    }
}