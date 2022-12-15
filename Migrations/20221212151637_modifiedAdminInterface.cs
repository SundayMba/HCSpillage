using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class modifiedAdminInterface : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783c11bc-75a6-463a-b8aa-7a2697f6ef4f",
                column: "ConcurrencyStamp",
                value: "bf8026e9-bb3e-4d41-ba27-d382b19dabc8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4719535-4dbb-4ea6-a41f-672c1a7f243e",
                column: "ConcurrencyStamp",
                value: "091307ab-881e-4abf-a3d4-22d8dd73b478");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36a578b8-e098-475b-8425-36290f6b30c8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eada4d20-4220-4266-82ca-ace0070df95c", "AQAAAAEAACcQAAAAEMmEBQ1WQNePG2QVxkgEWlVmz+nu/XnZoOxIOktXLU9fNmu3fuf7G7ZIWv95y6J5yQ==", "b7249054-e006-45ab-abbd-69b9b37b8180" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a805103-d331-4154-93e8-d6ca4aec72ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de11e71c-756a-4331-96ae-c58256a44628", "AQAAAAEAACcQAAAAEBf8ZMWQwaA/FLgIb/xHPrrs3jjy7P5DrFvvEUFWVj3nKb35ehM5YSQnu8RcpJDvjg==", "b96a51fd-d957-4857-ac09-754e199cc261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8279a54-566d-4c42-8f45-c62e8879dd4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d9c912b-d114-4f77-a449-3b5c3affa471", "AQAAAAEAACcQAAAAEDW9DBU/oFjcpH1uXHqzA41un4qQCgQJWSP6Ix4aLj4SlOzOKvNeQyP2Q7c7CLeHLw==", "0bb49f60-8c29-42ed-9a0d-bdeb4e57398b" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: "15:16");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: "15:16");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: "14:43");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: "14:43");
        }
    }
}
