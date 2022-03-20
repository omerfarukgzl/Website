using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Localizable(true)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Localizable(true)]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        [Localizable(true)]
        [DisplayName("Şifre Doğrula")]
        public string ConfirmPassword { get; set; }
    }
}
