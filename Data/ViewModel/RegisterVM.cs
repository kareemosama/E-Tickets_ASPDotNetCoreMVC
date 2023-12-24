using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModel
{
    public class RegisterVM
    {

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is Required")]
        public String FullName { get; set; }

        [Display(Name ="Email Address")]
        [Required(ErrorMessage ="Email Address is Required")]
        public String EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
