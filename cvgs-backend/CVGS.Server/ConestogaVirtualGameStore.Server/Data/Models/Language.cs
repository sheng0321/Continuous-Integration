using System.Text.Json.Serialization;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class Language
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

       [JsonIgnore]
        public ICollection<MemberPreference>? MemberPreferences { get; set; }
    }
}