using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HCSpillage.Dtos
{
    public class UserAccountViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string DeviceId { get; set; }

        [Required]
        [DisplayName("Device Token")]
        public string DeviceToken { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Compare("Password", ErrorMessage ="Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
