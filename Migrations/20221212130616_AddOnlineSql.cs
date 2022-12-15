using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCSpillage.Migrations
{
    /// <inheritdoc />
    public partial class AddOnlineSql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "Time",
                value: "13:06");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783c11bc-75a6-463a-b8aa-7a2697f6ef4f",
                column: "ConcurrencyStamp",
                value: "867617e1-e5c2-44ba-82d3-d2eda13738ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4719535-4dbb-4ea6-a41f-672c1a7f243e",
                column: "ConcurrencyStamp",
                value: "cd78d67e-4c23-4338-b537-1887f29af27d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36a578b8-e098-475b-8425-36290f6b30c8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7318e98c-9682-4aaf-b7d7-2b8aac9af443", "AQAAAAEAACcQAAAAEOeELIk4HVL51TH5dVBkQi4BcIi1k0Fc5Kch/ts49kXP/BMIsyzLiUeR3Hpo91vagg==", "d6793e89-9b69-488b-af64-a0f8f1cbe1a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a805103-d331-4154-93e8-d6ca4aec72ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beee4111-7b26-432a-afe6-bb20f6bae4fd", "AQAAAAEAACcQAAAAENFcZLdahy5IdI+YBHz1FPSzh3pbhB5+Y042U0a31SucV2BimQbEozT/it5QODIhjA==", "99221429-67cb-4b9f-a6da-aff804a9e736" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8279a54-566d-4c42-8f45-c62e8879dd4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c55d53d-e277-4fd2-8f31-11c4d71c75fb", "AQAAAAEAACcQAAAAEFsiaMLs0RDpJZS38/YcGBaqM7wPFRiN7FqzXHDXQ1AEdLS1RGavhOa/cc8UQlfqpw==", "129dc071-b304-4b3e-981c-579cfbb9cac8" });

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: "13:04");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: "13:04");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: "13:04");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: "13:04");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: "13:04");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: "13:04");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: "13:04");

            migrationBuilder.UpdateData(
                table: "DeviceData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: "13:04");
        }
    }
}
