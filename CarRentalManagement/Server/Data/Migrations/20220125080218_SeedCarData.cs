using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 25, 11, 32, 17, 700, DateTimeKind.Local).AddTicks(4065), new DateTime(2022, 1, 25, 11, 32, 17, 709, DateTimeKind.Local).AddTicks(2056), "Black", "System" },
                    { 2, "System", new DateTime(2022, 1, 25, 11, 32, 17, 709, DateTimeKind.Local).AddTicks(3586), new DateTime(2022, 1, 25, 11, 32, 17, 709, DateTimeKind.Local).AddTicks(3600), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(8936), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(8951), "Toyota", "System" },
                    { 2, "System", new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(9273), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(9283), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(5958), "Prius", "System" },
                    { 2, "System", new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6310), "Vitz", "System" },
                    { 3, "System", new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6314), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6316), "3 Series", "System" },
                    { 4, "System", new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6318), new DateTime(2022, 1, 25, 11, 32, 17, 710, DateTimeKind.Local).AddTicks(6320), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
