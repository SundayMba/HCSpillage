using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HCSpillage.Dtos
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Email")]
        public string  Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}
