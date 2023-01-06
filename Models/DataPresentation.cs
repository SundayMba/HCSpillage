using HCSpillage.Time;
using System.ComponentModel.DataAnnotations;

namespace HCSpillage.Models
{
    public class DataPresentation
    {

        [Key]
        public int Id { get; set; }    
        public string? Location { get; set; }
        public string? DeviceId { get; set; }
        public String date { get; set; } = DateTime.Now.ToShortDateString();
        public string Time { get; set; } = TimeConversion.GetFormattedTime();

        public  string? Data { get; set; }
        public string? Status { get; set; }
        public bool Verify { get; set;}
        public bool Config { get; set; }
        public string? Email { get; set; }

    }
}
