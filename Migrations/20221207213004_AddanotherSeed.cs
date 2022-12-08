using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddanotherSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62db9cbd-eec5-48f3-99f8-c387f7431407");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DeviceId", "DeviceToken", "Email", "EmailConfirmed", "FirstName", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ee9ade30-75ad-49c3-8cd5-eed659de8e74", 0, "2e470153-b4a0-47ef-b065-2a66a8e34951", "12345", "12345", "Sundinoh@gmail.com", true, null, null, null, false, null, null, null, "AQAAAAEAACcQAAAAEIBtylgrM+YiXrbEKbA1HyKZ2C/TfvIUSeaRLB86Zp+/COmBNtJmoNL3eyEkZ1JqbA==", null, false, "bf76e0b3-f249-40f7-bf2a-423f2ea6cca1", false, "Sundinoh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "21:30");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "21:30");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "21:30");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "21:30");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee9ade30-75ad-49c3-8cd5-eed659de8e74");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DeviceId", "DeviceToken", "Email", "EmailConfirmed", "FirstName", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62db9cbd-eec5-48f3-99f8-c387f7431407", 0, "0285cb45-3fce-405b-8238-267d325c94e7", "12345", "12345", "Sundinoh@gmail.com", true, null, null, null, false, null, null, null, "AQAAAAEAACcQAAAAEEBL03XCtGb5/nrmDdDkpIhKKJiDOWQN36dFReF6y7y+Y3hxf0G0vYylPTdlL239jw==", null, false, "6df67afd-a17d-4875-8944-09665a0e24e1", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "20:51");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "20:51");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "20:51");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "20:51");
        }
    }
}
