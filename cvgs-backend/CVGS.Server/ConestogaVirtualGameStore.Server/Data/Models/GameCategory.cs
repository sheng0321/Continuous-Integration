using System.Text.Json.Serialization;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class GameCategory
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        [JsonIgnore]
        public ICollection<Game>? Games { get; set; }  // Navigation property
    }
}
