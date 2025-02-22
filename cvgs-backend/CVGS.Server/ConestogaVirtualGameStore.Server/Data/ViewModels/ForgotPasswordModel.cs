using System.ComponentModel.DataAnnotations;

namespace ConestogaVirtualGameStore.Server.Data.ViewModels
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
