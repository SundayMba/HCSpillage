using HCSpillage.Data;
using HCSpillage.Dtos;
using HCSpillage.Time;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HCSpillage.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {

            var AdminId = "d8279a54-566d-4c42-8f45-c62e8879dd4a";
            var Admin_RoleId = "783c11bc-75a6-463a-b8aa-7a2697f6ef4f";
            var Customer_RoleId = "a4719535-4dbb-4ea6-a41f-672c1a7f243e";
            string sundayId = "5a805103-d331-4154-93e8-d6ca4aec72ba";
            string mbaId = "36a578b8-e098-475b-8425-36290f6b30c8";


            //new admin seed data
            var Admin = new ApplicationUser
            {
                Id = AdminId,
                Email = "Admin@gmail.com",
                UserName = "Admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = false,
                NormalizedUserName = "ADMIN@GMAIL.COM",
                LockoutEnabled = true,
            };

            //creating a password hasher for the admin
            var AdminHasher = new PasswordHasher<ApplicationUser>();
            Admin.PasswordHash = AdminHasher.HashPassword(Admin, "Admin");

            //admin seed
            builder.Entity<ApplicationUser>().HasData(Admin);

            //Customer seed data
            var Sunday = new ApplicationUser
            {
                Id = sundayId,
                DeviceId = "A123",
                Email = "emma@gmail.com",
                UserName = "emma@gmail.com",
                NormalizedEmail = "EMMA@GMAIL.COM",
                EmailConfirmed = false,
                NormalizedUserName = "EMMA@GMAIL.COM",
                LockoutEnabled = true,
            };
            var SundayPasswordHasher = new PasswordHasher<ApplicationUser>();
            Sunday.PasswordHash = SundayPasswordHasher.HashPassword(Sunday, "Sunday");
            builder.Entity<ApplicationUser>().HasData(Sunday);

            var Mba = new ApplicationUser
            {
                Id = mbaId,
                DeviceId = "A456",
                Email = "abc@gmail.com",
                UserName = "abc@GMAIL.COM",
                NormalizedEmail = "ABC@GMAIL.COM",
                EmailConfirmed = false,
                NormalizedUserName = "ABC@GMAIL.COM",
                LockoutEnabled = true,
            };
            var MbaPasswordHasher = new PasswordHasher<ApplicationUser>();
            Mba.PasswordHash = MbaPasswordHasher.HashPassword(Mba, "Mba");
            builder.Entity<ApplicationUser>().HasData(Mba);


            //role seeding
            builder.Entity<IdentityRole>().HasData(

                    new IdentityRole()
                    {
                        Id = Admin_RoleId,
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole()
                    {
                        Id = Customer_RoleId,
                        Name = "Customer",
                        NormalizedName = "CUSTOMER"
                    }
                );

            //admin role 
            builder.Entity<IdentityUserRole<string>>().HasData(
                        new IdentityUserRole<string>()
                        {
                            UserId = AdminId,
                            RoleId = Admin_RoleId,
                        }
                );

            //customer role sunday
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>()
            {
                UserId = sundayId,
                RoleId = Customer_RoleId,
            }
             );

            //customer role Mba
        builder.Entity<IdentityUserRole<string>>().HasData(
        new IdentityUserRole<string>()
        {
            UserId = mbaId,
            RoleId = Customer_RoleId,
        }
        );

            //incoming data seeding

            builder.Entity<DataPresentation>().HasData(

            new DataPresentation()
            {
                Id = 1,
                DeviceId = "A123",
                Data = "No",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = TimeConversion.GetFormattedTime(),
                Status = "On",
                Verify = false,
                Location = "Uyo",
                Config = true,
                Email = "emma@gmail.com"
            },
            new DataPresentation()
            {
                Id = 2,
                DeviceId = "A456",
                Data = "Yes",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = TimeConversion.GetFormattedTime(),
                Status = "Off",
                Verify = true,
                Location = "Abak",
                Config = false,
                Email = "abc@gmail.com"
            }

          );
        }
    }
}
