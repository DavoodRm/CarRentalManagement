using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class ValidationForAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "bbad1cce-a1b1-4905-ac83-657d699dda28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "0e4578ba-192b-4f36-a86d-6d965cf76512");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "985ba476-56c5-4725-873f-e7429ede1e92", "AQAAAAEAACcQAAAAEND9gyYhCxHg5aMIunY15BZGZ9IYH2pDk0zWFtIhSkhUppjLO+OG1/r7xM++Gr2STg==", "3c094a42-1993-4b2d-8072-ffd52912123b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22b774a3-a8ee-4c60-8e9e-cd309aba2f7a", "AQAAAAEAACcQAAAAEALkN5ES2KCUiGVPpTxL7nJ8Unkk3nOkdMJzjcYiPyv1kC0tVWFQAYlHNzMiqEhPqQ==", "32ac83fc-cb08-4dc4-8def-d0194aeced55" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 55, 49, 23, DateTimeKind.Local).AddTicks(8432), new DateTime(2022, 1, 26, 13, 55, 49, 28, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 55, 49, 28, DateTimeKind.Local).AddTicks(6336), new DateTime(2022, 1, 26, 13, 55, 49, 28, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 55, 49, 30, DateTimeKind.Local).AddTicks(1056), new DateTime(2022, 1, 26, 13, 55, 49, 30, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 55, 49, 30, DateTimeKind.Local).AddTicks(1385), new DateTime(2022, 1, 26, 13, 55, 49, 30, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 55, 49, 29, DateTimeKind.Local).AddTicks(8092), new DateTime(2022, 1, 26, 13, 55, 49, 29, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 55, 49, 29, DateTimeKind.Local).AddTicks(8441), new DateTime(2022, 1, 26, 13, 55, 49, 29, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 55, 49, 29, DateTimeKind.Local).AddTicks(8455), new DateTime(2022, 1, 26, 13, 55, 49, 29, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 55, 49, 29, DateTimeKind.Local).AddTicks(8459), new DateTime(2022, 1, 26, 13, 55, 49, 29, DateTimeKind.Local).AddTicks(8461) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "da8cbe10-84ca-4ffc-a522-d5ebeef79c98");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "15b53532-6ffd-4b88-a594-dd06080d2797");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e1c8a6-3da8-4d1b-8d0a-56ba7e977ae2", "AQAAAAEAACcQAAAAEOBYnWfWR8ZwJVAeZl7zRF/ObjdXF/bGTns5Z/gNZr4kk6Td6nZ3nVE84cW46+tIrQ==", "c8a1163a-8793-4d26-9995-52422db267d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbb6584e-48d5-42bd-93a8-3c68ee963828", "AQAAAAEAACcQAAAAEDVT0eLZE+mlxRwppFBWiNf8arnbWjCjRsLMVWYdqFBa7F5rr69bPAOhH2jdkb1v1g==", "e58d36d0-9fc9-4fb6-b14e-a5b7d163e67e" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 51, 3, 292, DateTimeKind.Local).AddTicks(3263), new DateTime(2022, 1, 26, 13, 51, 3, 300, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 51, 3, 300, DateTimeKind.Local).AddTicks(5368), new DateTime(2022, 1, 26, 13, 51, 3, 300, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(8484), new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(3689), new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(3711), new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 1, 26, 13, 51, 3, 302, DateTimeKind.Local).AddTicks(3724) });
        }
    }
}
