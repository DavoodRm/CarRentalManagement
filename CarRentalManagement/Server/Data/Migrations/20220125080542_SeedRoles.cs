using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "acb01e4c-3f3b-4bfd-a8bb-c1e6d07dee8e", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "13010508-ec0e-46a8-943b-bfc878159ef4", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 35, 42, 156, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 1, 25, 11, 35, 42, 165, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 35, 42, 165, DateTimeKind.Local).AddTicks(9449), new DateTime(2022, 1, 25, 11, 35, 42, 165, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(4323), new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(4650), new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(1209), new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(1637), new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(1651), new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(1655), new DateTime(2022, 1, 25, 11, 35, 42, 167, DateTimeKind.Local).AddTicks(1657) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 32, 17, 700, DateTimeKind.Local).AddTicks(4065), new DateTime(2022, 1, 25, 11, 32, 17, 709, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 32, 17, 709, DateTimeKind.Local).AddTicks(3586), new DateTime(2022, 1, 25, 11, 32, 17, 709, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(8936), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(9273), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6314), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6318), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6320) });
        }
    }
}
