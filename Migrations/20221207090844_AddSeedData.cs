using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeviceData",
                columns: new[] { "Id", "Config", "Data", "DeviceId", "Location", "Status", "Time", "Verify", "date" },
                values: new object[,]
                {
                    { 1, true, "Gas detected", "A123", "Uyo", "On", "09:08", false, "07/12/2022" },
                    { 2, false, "Gas detected", "A223", "Abak", "Off", "09:08", true, "07/12/2022" },
                    { 3, true, "Gas detected", "A523", "Abak", "Off", "09:08", true, "07/12/2022" },
                    { 4, false, "Gas detected", "A423", "Oron", "On", "09:08", false, "07/12/2022" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
