using ConestogaVirtualGameStore.Server.Data.Enums;
using ConestogaVirtualGameStore.Server.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConestogaVirtualGameStore.Server.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<CvgsEvent> CvgsEvents { get; set; } = default!;
        public DbSet<EventRegister> EventRegisters { get; set; } = default!;
        public DbSet<Game> Games { get; set; } = default!;

        public DbSet<Address> Addresses { get; set; }
        public DbSet<WishList> WishLists { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<GameReview> GameReviews { get; set; }

        public DbSet<GameCategory> GameCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>()
           .HasOne(a => a.UserProfile)
           .WithMany(u => u.Addresses)
           .HasForeignKey(a => a.MemberID)
           .HasPrincipalKey(u => u.UserId);

            modelBuilder.Entity<WishList>()
                .HasOne(w => w.UserProfile)
                .WithMany(u => u.WishLists)
                .HasForeignKey(w => w.MemberID)
                .HasPrincipalKey(u => u.UserId);
            modelBuilder.Entity<WishList>()
                .HasIndex(w => new { w.MemberID, w.GameID })
                .IsUnique();

            modelBuilder.Entity<Order>()
           .HasOne(o => o.UserProfile)
           .WithMany(u => u.Orders)
           .HasForeignKey(o => o.MemberID)
           .HasPrincipalKey(u => u.UserId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Game)
                .WithMany(g => g.OrderDetails)
                .HasForeignKey(od => od.GameID);
            // Composite key for OrderDetail (OrderID + GameID should be unique per order)
            modelBuilder.Entity<OrderDetail>()
      .HasKey(od => od.OrderDetailID); // Primary key

            modelBuilder.Entity<OrderDetail>()
                .HasIndex(od => new { od.OrderID, od.GameID }) // Unique index for composite key
                .IsUnique();

            modelBuilder.Entity<EventRegister>()
           .HasOne(er => er.Event)
           .WithMany(e => e.EventRegisters)
           .HasForeignKey(er => er.EventId);

            modelBuilder.Entity<EventRegister>()
                .HasOne(er => er.UserProfile)
                .WithMany(u => u.EventRegisters)
                .HasForeignKey(er => er.MemberId);

            modelBuilder.Entity<GameReview>()
           .HasOne(gr => gr.UserProfile)
           .WithMany(u => u.GameReviews)
           .HasForeignKey(gr => gr.MemberID);

            modelBuilder.Entity<GameReview>()
                .HasOne(gr => gr.Game)
                .WithMany(g => g.GameReviews)
                .HasForeignKey(gr => gr.GameID);

            modelBuilder.Entity<Game>()
           .HasOne(g => g.GameCategory)
           .WithMany(gc => gc.Games)
           .HasForeignKey(g => g.GameCategoryId);

            // Seed data
            modelBuilder.Entity<CvgsEvent>().HasData(MockData.MockData.GetMockEvents().ToArray());
            modelBuilder.Entity<Game>().HasData(MockData.MockData.GetGames().ToArray());

            modelBuilder.Entity<GameCategory>().HasData(MockData.MockData.GetGameCategories().ToArray());

            modelBuilder.Entity<Game>().HasData(MockData.MockData.GetGames().ToArray());
           
            modelBuilder.Entity<FavoritePlatform>().HasData(MockData.MockData.GetMockPlatforms().ToArray());

            modelBuilder.Entity<Language>().HasData(MockData.MockData.GetMockLanguages().ToArray());
        }
        public DbSet<ConestogaVirtualGameStore.Server.Data.Models.MemberPreference> MemberPreference { get; set; } = default!;
        public DbSet<ConestogaVirtualGameStore.Server.Data.Models.Language> Language { get; set; } = default!;
        public DbSet<ConestogaVirtualGameStore.Server.Data.Models.FavoritePlatform> FavoritePlatform { get; set; } = default!;
     

        }
        
    
}
