using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783c11bc-75a6-463a-b8aa-7a2697f6ef4f",
                column: "ConcurrencyStamp",
                value: "ce10b012-e56b-49ed-ad44-2e9c16c1e2a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4719535-4dbb-4ea6-a41f-672c1a7f243e",
                column: "ConcurrencyStamp",
                value: "19c02db1-5217-4bbd-8f52-d901e3800ab4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36a578b8-e098-475b-8425-36290f6b30c8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed356ff1-4b2a-4c7a-992e-28a19070a2aa", "AQAAAAEAACcQAAAAECQd/YmTx5Hcj3ZI8g4lLUkOPakZwQiGm1EnibGSybWLoBwCB4mcpUwoufqFAywrvw==", "043220c7-7818-4aee-8d09-2dd18f51a146" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a805103-d331-4154-93e8-d6ca4aec72ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45916ba6-3025-4d19-95a5-15089d040adf", "AQAAAAEAACcQAAAAEObkWntWxJwkOOW+35QC+BrNdAjrCOjE8gx8+y1xfBbm1brez5mI6GSKZL/Z6GZuag==", "561c3456-d4e4-4bfe-b62d-133ac5d2e961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8279a54-566d-4c42-8f45-c62e8879dd4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1923a151-a600-4cf9-b51d-25adce33bcf1", "AQAAAAEAACcQAAAAEPVGCOozxFQhlxFbgaMN9QWESO807w/Dmg6Mg0zqL322HHJsdWuNjPzc7TRYk03PhA==", "45d7815b-ebc7-46d3-b7e8-3022be445a4a" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "13:31");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "13:31");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Time" },
                values: new object[] { "emma@gmail.com", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "13:31");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: "13:31");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: "13:31");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: "13:31");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: "13:31");

            migrationBuilder.InsertData(
                table: "DeviceData",
                columns: new[] { "Id", "Config", "Data", "DeviceId", "Email", "Location", "Status", "Time", "Verify", "date" },
                values: new object[,]
                {
                    { 9, false, "Gas detected", "B123", "luis@gmail.com", "Oron", "On", "13:31", false, "12/12/2022" },
                    { 10, false, "Gas detected", "A982", "Samuel@gmail.com", "Oron", "On", "13:31", false, "12/12/2022" },
                    { 11, false, "Gas Not Detected", "A093", "Oboho@gmail.com", "Oron", "On", "13:31", false, "12/12/2022" },
                    { 12, false, "Gas detected", "A938", "Solomon@gmail.com", "Oron", "OFF", "13:31", true, "12/12/2022" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783c11bc-75a6-463a-b8aa-7a2697f6ef4f",
                column: "ConcurrencyStamp",
                value: "ea1a4aa1-a2d4-4132-a0e3-8debf0fab0cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4719535-4dbb-4ea6-a41f-672c1a7f243e",
                column: "ConcurrencyStamp",
                value: "853c538c-fc2b-4ffa-bc7c-803dd64eb082");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36a578b8-e098-475b-8425-36290f6b30c8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba00bc22-9b9d-48e2-aaef-95c4a1ea6246", "AQAAAAEAACcQAAAAEH7C9iOyU42DzAXqryasuPnQbI0+LKBCYp21LfoXNIvixFhdpPTSEhhKxnoSp0SfSQ==", "0bb40c88-773e-4a0b-9b23-08686a130aa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a805103-d331-4154-93e8-d6ca4aec72ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "084a9260-248f-44b1-bc7b-e1ce63ad7e32", "AQAAAAEAACcQAAAAEKf1qiQ6g6vRJGUKxwVTHv8wNpu+O/zVfxLDIa8EvOPJuFPNFaO/txgUPVTmrDEamQ==", "c34cbded-4eaf-4d05-be5c-aa187713f058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8279a54-566d-4c42-8f45-c62e8879dd4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64683401-2cd5-4bec-98cf-808b40bb7ceb", "AQAAAAEAACcQAAAAEC4v4Dv8i74Rf8Kwsq6DE2s1FiqcLKbY9eF/Mwisr+sOG00MmpMzQd+4GQGpeCx96g==", "222c5e46-998d-43ff-8742-f86f79b97b18" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "13:06");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "13:06");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Time" },
                values: new object[] { "emma.@gmail.com", "13:06" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "13:06");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: "13:06");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: "13:06");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: "13:06");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: "13:06");
        }
    }
}
