using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddOnlineDbSql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "badc42d6-e71e-4f97-bbb2-e21c10cd72ed");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DeviceId", "DeviceToken", "Email", "EmailConfirmed", "FirstName", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "89e2dd25-e20b-48fc-973e-6802bd7a5a2a", 0, "1668b450-8d19-4d48-8898-13c830733ad8", "12345", "12345", "Sundinoh@gmail.com", true, null, null, null, false, null, null, null, "AQAAAAEAACcQAAAAENJqu1rXsVi5B2qHsF+nRUwlRW8bTyQQtl/QmIRBGXR5ijPA6SOCjhEspk9tEYD4BA==", null, false, "054407af-7271-412a-bff0-76ad23143816", false, "Sundinoh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "22:35");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "22:35");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "22:35");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "22:35");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e2dd25-e20b-48fc-973e-6802bd7a5a2a");

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
    }
}
