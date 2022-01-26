using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class ValidationForCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "cdda64c6-f646-4303-bd66-1cbee87e36c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "05fb2017-f675-4dca-af80-cb5c4598f6d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd7f64bd-6d16-49dc-a18d-d293fa61b3c1", "AQAAAAEAACcQAAAAEAFE/Sga+tFyrPdXd8xZks/RM+RUJbx5p5gi4amx1sz6QSn5P8gH05bxJALftscvtg==", "7309e074-3d38-4dbc-8ed7-dd4c8d3489d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c16cfe45-7b7c-48c0-8d9d-83ea6823cf71", "AQAAAAEAACcQAAAAELd0qRLHhw1ANMmGRAJ4FBeQwn3uboZ60gcy0ynGGlZEVyy7mJXwEAPw7A7FxxDJ7Q==", "f93bf967-62ae-400d-9e38-cb41b7e434c4" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 43, 50, 430, DateTimeKind.Local).AddTicks(4319), new DateTime(2022, 1, 26, 13, 43, 50, 436, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 43, 50, 436, DateTimeKind.Local).AddTicks(4645), new DateTime(2022, 1, 26, 13, 43, 50, 436, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 43, 50, 438, DateTimeKind.Local).AddTicks(66), new DateTime(2022, 1, 26, 13, 43, 50, 438, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 43, 50, 438, DateTimeKind.Local).AddTicks(401), new DateTime(2022, 1, 26, 13, 43, 50, 438, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 43, 50, 437, DateTimeKind.Local).AddTicks(7084), new DateTime(2022, 1, 26, 13, 43, 50, 437, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 43, 50, 437, DateTimeKind.Local).AddTicks(7425), new DateTime(2022, 1, 26, 13, 43, 50, 437, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 43, 50, 437, DateTimeKind.Local).AddTicks(7438), new DateTime(2022, 1, 26, 13, 43, 50, 437, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 13, 43, 50, 437, DateTimeKind.Local).AddTicks(7443), new DateTime(2022, 1, 26, 13, 43, 50, 437, DateTimeKind.Local).AddTicks(7444) });
        }
    }
}
