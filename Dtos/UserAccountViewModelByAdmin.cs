using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HCSpillage.Dtos
{
    public class UserAccountViewModelByAdmin
    {
        [Required]
        public string  Location { get; set; }

        [Required]
        public string DeviceId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
