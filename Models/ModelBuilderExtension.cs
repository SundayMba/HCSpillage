using HCSpillage.Data;
using HCSpillage.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HCSpillage.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {

            var Id = Guid.NewGuid().ToString();
            //new admin seed data
            var Admin = new ApplicationDbUser
            {
                Id = Id,
                DeviceId = "12345",
                DeviceToken = "12345",
                UserName = "Sundinoh@gmail.com",
                Email = "Sundinoh@gmail.com",
                EmailConfirmed = true,
            };

            //creating a password hasher for the admin
            var ph = new PasswordHasher<ApplicationDbUser>();
             Admin.PasswordHash = ph.HashPassword(Admin, "Intmain(1997)");

            builder.Entity<ApplicationDbUser>().HasData(Admin);

            builder.Entity<DataPresentation>().HasData(

            new DataPresentation()
            {
                Id = 1,
                DeviceId = "A123",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = false,
                Location = "Uyo",
                Config = true
            },
            new DataPresentation()
            {
                Id = 2,
                DeviceId = "A223",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "Off",
                Verify = true,
                Location = "Abak",
                Config = false
            },
            new DataPresentation()
            {
                Id = 3,
                DeviceId = "A523",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "Off",
                Verify = true,
                Location = "Abak",
                Config = true
            },
            new DataPresentation()
            {
                Id = 4,
                DeviceId = "A423",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = false,
                Location = "Oron",
                Config = false
            }
          );
        }
    }
}
