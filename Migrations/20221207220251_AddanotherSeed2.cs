using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddanotherSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c16bf689-a87b-4248-9ee6-a61f281889f8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DeviceId", "DeviceToken", "Email", "EmailConfirmed", "FirstName", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d21bbc1f-1e0e-4928-8c2f-5d70d12c4f11", 0, "7e10e293-e339-4ed4-9ec2-b0715a9ee8d6", "12345", "12345", "Sundinoh@gmail.com", true, null, null, null, false, null, null, null, "AQAAAAEAACcQAAAAEDrjSgjOJXbeHUbpeLl1MLc+n8c723IYNRATOWYiFkbkNmnwGxF8zqAVN09ciHeQQg==", null, false, "133e1c2b-4807-497b-b778-4267334f005e", false, "Sundinoh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "22:02");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "22:02");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "22:02");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "22:02");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d21bbc1f-1e0e-4928-8c2f-5d70d12c4f11");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DeviceId", "DeviceToken", "Email", "EmailConfirmed", "FirstName", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c16bf689-a87b-4248-9ee6-a61f281889f8", 0, "e85a59bb-2518-47db-a10d-38751c6975ce", "12345", "12345", "Sundinoh@gmail.com", true, null, null, null, false, null, null, null, "AQAAAAEAACcQAAAAEPxNgFM8TMs/TgSmsFNAOiX7qlL29+6qfGiqaw0aL2ExdtTiTaUw69QU+rfNyjt5pg==", null, false, "c35d1785-f85f-4603-a812-d6212e98c1a0", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "21:58");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "21:58");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "21:58");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "21:58");
        }
    }
}
