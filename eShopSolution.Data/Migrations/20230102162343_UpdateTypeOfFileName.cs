using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class UpdateTypeOfFileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0d579b1a-3da7-4093-ae10-52cc57569bf2"),
                column: "ConcurrencyStamp",
                value: "eb2bfb41-af3a-4f13-a0f3-d650da554858");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("72cdb154-f7bf-4ca2-adba-360344f8cb3a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9dbf76c1-f20a-4ce1-96fc-aa50aa3139b8", "AQAAAAEAACcQAAAAEOYYkEUgAftfzdtfzqNuDhmAl37cnljs3YsTfN4rOfa72bsIIpbJfyVVT3Jp5h85kQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 1, 2, 23, 23, 42, 655, DateTimeKind.Local).AddTicks(6708));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0d579b1a-3da7-4093-ae10-52cc57569bf2"),
                column: "ConcurrencyStamp",
                value: "f351ed35-e7b7-4d7f-abc1-f2bf1cf4ad87");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("72cdb154-f7bf-4ca2-adba-360344f8cb3a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ed091e8-0e79-406e-a300-d5d5059cce0e", "AQAAAAEAACcQAAAAEEwb6mnZ9ej0kokD9fR3zhIG/Iz4bUDciz+EZf2ISYbaXZ5zugA+6j+IRzx+DVvYqw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 12, 27, 23, 32, 51, 154, DateTimeKind.Local).AddTicks(5116));
        }
    }
}
