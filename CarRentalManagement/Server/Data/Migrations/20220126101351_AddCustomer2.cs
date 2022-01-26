using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddCustomer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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
    }
}
