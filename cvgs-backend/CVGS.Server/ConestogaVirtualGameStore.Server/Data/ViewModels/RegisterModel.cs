﻿using System.ComponentModel.DataAnnotations;

namespace ConestogaVirtualGameStore.Server.Data.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? DisplayName { get; set; }

       // public string? Role { get; set; } = "Member";
    }
}
