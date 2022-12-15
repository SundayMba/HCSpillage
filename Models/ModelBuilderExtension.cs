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
                Email = "Emma@gmail.com",
                UserName = "Emma@gmail.com",
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
                DeviceId = "A423",
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
                Data = "Yes",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = false,
                Location = "Uyo",
                Config = true,
                Email = "emma@gmail.com"
            },
            new DataPresentation()
            {
                Id = 2,
                DeviceId = "A123",
                Data = "Yes",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = true,
                Location = "Uyo",
                Config = true,
                Email = "emma.@gmail.com"
            },
            new DataPresentation()
            {
                Id = 3,
                DeviceId = "A123",
                Data = "Yes",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = true,
                Location = "Uyo",
                Config = false,
                Email = "emma@gmail.com"
            },
            new DataPresentation()
            {
                Id = 4,
                DeviceId = "A423",
                Data = "Yes",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = false,
                Location = "Oron",
                Config = false,
                Email = "abc@gmail.com"
            },
            new DataPresentation()
            {
                Id = 5,
                DeviceId = "A423",
                Data = "Yes",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = false,
                Location = "Oron",
                Config = false,
                Email = "abc@gmail.com"
            },
                new DataPresentation()
                {
                    Id = 6,
                    DeviceId = "A423",
                    Data = "No",
                    date = DateTime.UtcNow.ToShortDateString(),
                    Time = DateTime.UtcNow.ToShortTimeString(),
                    Status = "On",
                    Verify = true,
                    Location = "Oron",
                    Config = false,
                    Email = "abc@gmail.com"
                },
                new DataPresentation()
                {
                    Id = 7,
                    DeviceId = "A423",
                    Data = "No",
                    date = DateTime.UtcNow.ToShortDateString(),
                    Time = DateTime.UtcNow.ToShortTimeString(),
                    Status = "On",
                    Verify = true,
                    Location = "Oron",
                    Config = true,
                    Email = "abc@gmail.com"
                },
                new DataPresentation()
                {
                    Id = 8,
                    DeviceId = "A423",
                    Data = "No",
                    date = DateTime.UtcNow.ToShortDateString(),
                    Time = DateTime.UtcNow.ToShortTimeString(),
                    Status = "On",
                    Verify = false,
                    Location = "Oron",
                    Config = false,
                    Email = "abc@gmail.com"
                },
                new DataPresentation()
                {
                    Id = 9,
                    DeviceId = "B123",
                    Data = "No",
                    date = DateTime.UtcNow.ToShortDateString(),
                    Time = DateTime.UtcNow.ToShortTimeString(),
                    Status = "On",
                    Verify = false,
                    Location = "Oron",
                    Config = false,
                    Email = "luis@gmail.com"
                },
                new DataPresentation()
                {
                    Id = 10,
                    DeviceId = "A982",
                    Data = "No",
                    date = DateTime.UtcNow.ToShortDateString(),
                    Time = DateTime.UtcNow.ToShortTimeString(),
                    Status = "On",
                    Verify = false,
                    Location = "Oron",
                    Config = false,
                    Email = "Samuel@gmail.com"
                }, new DataPresentation()
                {
                    Id = 11,
                    DeviceId = "A093",
                    Data = "No",
                    date = DateTime.UtcNow.ToShortDateString(),
                    Time = DateTime.UtcNow.ToShortTimeString(),
                    Status = "On",
                    Verify = false,
                    Location = "Oron",
                    Config = false,
                    Email = "Oboho@gmail.com"
                }, new DataPresentation()
                {
                    Id = 12,
                    DeviceId = "A938",
                    Data = "No",
                    date = DateTime.UtcNow.ToShortDateString(),
                    Time = DateTime.UtcNow.ToShortTimeString(),
                    Status = "OFF",
                    Verify = true,
                    Location = "Oron",
                    Config = false,
                    Email = "Solomon@gmail.com"
                }

          );
        }
    }
}
