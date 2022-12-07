using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HCSpillage.Dtos
{
    public class UserAccountViewModelByAdmin
    {
        [Required]
        [DisplayName("First Name")]
        public string Firstname { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string Lastname { get; set; }
      
        public string Name { get; set; }
        public string Username { get; set; }
        [Required]
        public string Location { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string DeviceId { get; set; }

        [Phone]
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("Device Token")]
        public string DeviceToken { get; set; }

    }
}
