using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HCSpillage.Data
{
    public class ApplicationDbUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Location { get; set; }
        public string? DeviceId { get; set; }
        public string? DeviceToken { get; set; }
    }
}
