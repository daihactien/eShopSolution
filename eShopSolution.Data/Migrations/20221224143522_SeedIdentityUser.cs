using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 24, 21, 35, 22, 4, DateTimeKind.Local).AddTicks(4750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 24, 20, 51, 3, 508, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("0d579b1a-3da7-4093-ae10-52cc57569bf2"), "c6370d01-21a7-4d4b-a150-7035b08b9eb8", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("72cdb154-f7bf-4ca2-adba-360344f8cb3a"), new Guid("0d579b1a-3da7-4093-ae10-52cc57569bf2") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("72cdb154-f7bf-4ca2-adba-360344f8cb3a"), 0, "8b9d46eb-00b3-4cac-bcaa-41efbf437c90", new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenquanghien3005@gmail.com", true, "Nguyen Quang", "Hien", false, null, "nguyenquanghien3005@gmail.com", "admin", "AQAAAAEAACcQAAAAENA/Vjavwyx6cX3sKdiHhZbEL2GmPgrzDTDa2gBW3OmenoLp7PGBbtHUoGZppm83qg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 12, 24, 21, 35, 22, 21, DateTimeKind.Local).AddTicks(1809));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0d579b1a-3da7-4093-ae10-52cc57569bf2"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("72cdb154-f7bf-4ca2-adba-360344f8cb3a"), new Guid("0d579b1a-3da7-4093-ae10-52cc57569bf2") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("72cdb154-f7bf-4ca2-adba-360344f8cb3a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 24, 20, 51, 3, 508, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 24, 21, 35, 22, 4, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 12, 24, 20, 51, 3, 522, DateTimeKind.Local).AddTicks(4771));
        }
    }
}
