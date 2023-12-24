using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModel
{
    public class LoginVM
    {
        [Display(Name ="Email Address")]
        [Required(ErrorMessage ="Email Address is Required")]
        public String EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
