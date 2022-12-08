using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeviceToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeviceId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62db9cbd-eec5-48f3-99f8-c387f7431407");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeviceToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeviceId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "12:59");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "12:59");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "12:59");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "12:59");
        }
    }
}
