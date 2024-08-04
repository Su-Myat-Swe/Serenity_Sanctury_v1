using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Serenity_Sanctury_v1.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage ="Email Address is required.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }    

    }
}
