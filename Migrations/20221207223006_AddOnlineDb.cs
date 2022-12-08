using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddOnlineDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d21bbc1f-1e0e-4928-8c2f-5d70d12c4f11");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DeviceId", "DeviceToken", "Email", "EmailConfirmed", "FirstName", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "badc42d6-e71e-4f97-bbb2-e21c10cd72ed", 0, "5f5cf211-470f-4c6e-a82e-87550f45cbb5", "12345", "12345", "Sundinoh@gmail.com", true, null, null, null, false, null, null, null, "AQAAAAEAACcQAAAAEOSGIUR6/gTJsHNyMf4qdV/uCgColD1tBa5y+C+HPWXlVObUWJLNTq1nSnt5JAd8Zw==", null, false, "48ae1004-1627-44c9-97e8-0b6c6007dd44", false, "Sundinoh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "22:30");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "22:30");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "22:30");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "22:30");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "badc42d6-e71e-4f97-bbb2-e21c10cd72ed");

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
    }
}
