using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddAnotherTimeZone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783c11bc-75a6-463a-b8aa-7a2697f6ef4f",
                column: "ConcurrencyStamp",
                value: "ca4217b7-a4bb-4ce7-8b56-0e4d1974080d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4719535-4dbb-4ea6-a41f-672c1a7f243e",
                column: "ConcurrencyStamp",
                value: "c5f1f22a-0aee-4e2b-8191-7d207ef37386");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36a578b8-e098-475b-8425-36290f6b30c8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8bb4914-5906-40ae-9a36-6eabd8880644", "AQAAAAEAACcQAAAAEFq0X0w0Pq4zkzWSEBlLvzimuIZguxvkA4JDy0psIRLTc/PZ/mRh5cwrF+GV6hrN4Q==", "088d451c-4966-4661-82d8-c6ab7d95e0a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a805103-d331-4154-93e8-d6ca4aec72ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "000725df-56bf-4ab1-9680-1e8a6f523d34", "AQAAAAEAACcQAAAAEMo2m0Rmiz/8rW/cZ4O/pfnMkGY0qCp8MJjGxvXcabbc2VpqYfgMk49oMmlyCbBPxQ==", "9716774b-cc93-4969-9742-cfccfcf18d9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8279a54-566d-4c42-8f45-c62e8879dd4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25adf90a-d472-4a15-b846-6e1f39788084", "AQAAAAEAACcQAAAAEOz0Pa0nUtRMN5bbjLvd6HcI95VPDhco/3nu/hRAsxxhGtJ9fuRV6obg1EZqC5fbdg==", "2baeaec6-9c95-4d04-91a4-df87bf5b2fd7" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Yes", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Yes", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Yes", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Yes", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Yes", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No", "14:43" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No", "14:43" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Data", "Time" },
                values: new object[] { "No Gas Detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No Gas Detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Data", "Time" },
                values: new object[] { "No Gas Detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas Not Detected", "13:31" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Data", "Time" },
                values: new object[] { "Gas detected", "13:31" });
        }
    }
}
