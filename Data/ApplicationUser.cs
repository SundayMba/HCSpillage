using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HCSpillage.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? DeviceId { get; set; }
    }
}
