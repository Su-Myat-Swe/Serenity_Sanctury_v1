using System.ComponentModel.DataAnnotations;

namespace Serenity_Sanctury_v1.ViewModels
{
    public class RegisterViewModel
    {

        // from IdentityUser class
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage ="Password do not match!")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
