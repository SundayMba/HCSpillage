using System.ComponentModel.DataAnnotations;

namespace HCSpillage.Dtos
{
    public class DataPresentationDto
    {
        [Required]
        public string Location { get; set; }

        [Required]
        public string DeviceId { get; set; }
    }
}
