using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class F1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RentalRate",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "5c4081c4-155a-4f21-adb0-a9304b56ce63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "c3087a15-29dd-4b6f-8345-27819fd5cfbe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6cd94ee-ebea-424c-afa3-77f163263e03", "AQAAAAEAACcQAAAAELcYD/4wkPRwO3Vja57eKTmDohP+QpqyGICmRMob0spP7+Gs73XvebmMbX9EW1hxAw==", "8af8ecb5-fb27-4d25-98c8-fcdc363c0b5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f6efd6d-3727-46ce-b822-62e921afdc16", "AQAAAAEAACcQAAAAEO1wAbFdZQErAdWIVYnvFeEm2UZRgodTaQe1dn287aylRnS2B3VL2TMn5gZkLevQmA==", "bfe29c32-7cc3-4cec-adaf-271c9f15972e" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 17, 17, 50, 953, DateTimeKind.Local).AddTicks(8433), new DateTime(2022, 1, 25, 17, 17, 50, 963, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 17, 17, 50, 963, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 1, 25, 17, 17, 50, 963, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(6513), new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(6954), new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(3771), new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(3784), new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(3789), new DateTime(2022, 1, 25, 17, 17, 50, 964, DateTimeKind.Local).AddTicks(3791) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentalRate",
                table: "Vehicles");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "447d3eb5-d7fe-4dc2-946a-f63c5ff22c00", "AQAAAAEAACcQAAAAEBw0kmcys/noAP+Ec2nRJnDgsyU042JZURIW5higkT4+u6FyC5oKy1pJ1bbp4Zm9ww==", "222c3638-c059-4826-9a2b-329cf17b75b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "803bf6db-0a9d-47d8-8568-14b90190cbd2", "AQAAAAEAACcQAAAAEOxMwgwlBFoKjHOOmFvqA9cFFJYRkpIn1nKmB8pnhkItYPj33GesxSDqTE2crDAvwg==", "9fa148c6-31e3-4706-9bb8-c5622c19e35b" });

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
        }
    }
}
