﻿using Microsoft.AspNetCore.Identity;

namespace ConestogaVirtualGameStore.Server.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? DisplayName { get; set; }
    }
}
