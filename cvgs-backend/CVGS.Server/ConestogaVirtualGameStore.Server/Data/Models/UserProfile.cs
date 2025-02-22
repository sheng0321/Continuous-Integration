using System.ComponentModel.DataAnnotations;
using ConestogaVirtualGameStore.Server.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    public class UserProfile
    {
       
        [Key]
        [Required]
        public string UserId { get; set; }
        [Required]
        public string? DisplayName { get; set; }
        [Required]
        public string? Email { get; set; }
      
        public string? Gender { get; set; }

        public DateOnly BirthOfDate { get; set; }
      
        public bool IsReceivePromotionalEmails { get; set; }

        // Navigation property
        public ICollection<Address>? Addresses { get; set; } 
        public ICollection<WishList>? WishLists { get; set; }  
        public ICollection<Order>? Orders { get; set; }
        public ICollection<EventRegister>? EventRegisters { get; set; }
        public ICollection<GameReview>? GameReviews { get; set; }  

    }


}