using HCSpillage.Time;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HCSpillage.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? DeviceId { get; set; }
        public string Location { get; set; }
        public string Date { get; set; } = DateTime.Now.ToShortDateString();
        public string Time { get; set; } = TimeConversion.GetFormattedTime();
        public bool Verify { get; set; }
    }
}
