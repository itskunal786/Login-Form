using System.ComponentModel.DataAnnotations;

namespace UserAccountUI.Models
{
    public class UserModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Login ID")]
        public string LoginId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
