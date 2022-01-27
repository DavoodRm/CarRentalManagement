using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddImageProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ba287aa6-8371-49e5-99da-b28a2ef2e07e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "a0c143d9-8c5f-4b8b-9b1f-73a36397170e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8baa6eed-279b-4b7d-ac52-486996df6ba3", "AQAAAAEAACcQAAAAEAAh+h/DCZp0A6DXcQ01WjeqqtzmKPuGj0V5XRZCBC+pMUXvCipY+cslaOa66t2gLQ==", "c8214a0e-2f14-458f-a92b-4a568bdda203" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3abcf483-b3ee-499f-b283-0fa1b3152153", "AQAAAAEAACcQAAAAEKw31KNXU0uE6fhUGOXc08qFGF9qMSd/uMtWqQEZujTbtgPzCgk43Zz54qnIS9zyVA==", "060bd85d-fce5-42a4-9c51-d463e606d0e0" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 8, 15, 58, 437, DateTimeKind.Local).AddTicks(5901), new DateTime(2022, 1, 27, 8, 15, 58, 443, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 8, 15, 58, 443, DateTimeKind.Local).AddTicks(6174), new DateTime(2022, 1, 27, 8, 15, 58, 443, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 8, 15, 58, 445, DateTimeKind.Local).AddTicks(155), new DateTime(2022, 1, 27, 8, 15, 58, 445, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 8, 15, 58, 445, DateTimeKind.Local).AddTicks(474), new DateTime(2022, 1, 27, 8, 15, 58, 445, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 8, 15, 58, 444, DateTimeKind.Local).AddTicks(7391), new DateTime(2022, 1, 27, 8, 15, 58, 444, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 8, 15, 58, 444, DateTimeKind.Local).AddTicks(7735), new DateTime(2022, 1, 27, 8, 15, 58, 444, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 8, 15, 58, 444, DateTimeKind.Local).AddTicks(7747), new DateTime(2022, 1, 27, 8, 15, 58, 444, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 8, 15, 58, 444, DateTimeKind.Local).AddTicks(7751), new DateTime(2022, 1, 27, 8, 15, 58, 444, DateTimeKind.Local).AddTicks(7753) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

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
    }
}
