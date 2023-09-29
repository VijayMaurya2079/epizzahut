using System.ComponentModel.DataAnnotations;

namespace ePizzaHub.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please enter email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}
