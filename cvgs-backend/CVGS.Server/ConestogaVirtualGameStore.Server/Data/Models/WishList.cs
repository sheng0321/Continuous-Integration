namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class WishList
    {
        public Guid WishListID { get; set; }
        public string? MemberID { get; set; }
        public Guid GameID { get; set; }
        public DateTime DateAdded { get; set; }

        public UserProfile? UserProfile { get; set; }  // Navigation property
    }
}
