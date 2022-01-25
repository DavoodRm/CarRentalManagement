using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3f66f8d5-1a61-45dd-b8f4-5ebc9c7f3b74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "8a225845-b29d-4aa6-8ee9-aff8fb108490");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "447d3eb5-d7fe-4dc2-946a-f63c5ff22c00", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBw0kmcys/noAP+Ec2nRJnDgsyU042JZURIW5higkT4+u6FyC5oKy1pJ1bbp4Zm9ww==", null, false, "222c3638-c059-4826-9a2b-329cf17b75b7", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "803bf6db-0a9d-47d8-8568-14b90190cbd2", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOxMwgwlBFoKjHOOmFvqA9cFFJYRkpIn1nKmB8pnhkItYPj33GesxSDqTE2crDAvwg==", null, false, "9fa148c6-31e3-4706-9bb8-c5622c19e35b", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 42, 55, 375, DateTimeKind.Local).AddTicks(1764), new DateTime(2022, 1, 25, 11, 42, 55, 382, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 42, 55, 382, DateTimeKind.Local).AddTicks(4305), new DateTime(2022, 1, 25, 11, 42, 55, 382, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(8798), new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(9134), new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(5958), new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(6308), new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(6322), new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(6326), new DateTime(2022, 1, 25, 11, 42, 55, 383, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "acb01e4c-3f3b-4bfd-a8bb-c1e6d07dee8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "13010508-ec0e-46a8-943b-bfc878159ef4");

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
    }
}
