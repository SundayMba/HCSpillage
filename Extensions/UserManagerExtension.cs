using HCSpillage.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HCSpillage.Extensions
{
    public static class UserManagerExtension
    {
        public static async Task<ApplicationUser> FindUserByDeviceId(this UserManager<ApplicationUser> userManager, string deviceId)
        {
            return await userManager.Users.SingleAsync(user => user.DeviceId == deviceId);
        }
    }
}
