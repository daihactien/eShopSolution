using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddEntityImageProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 24, 21, 35, 22, 4, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 24, 21, 35, 22, 4, DateTimeKind.Local).AddTicks(4750),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0d579b1a-3da7-4093-ae10-52cc57569bf2"),
                column: "ConcurrencyStamp",
                value: "c6370d01-21a7-4d4b-a150-7035b08b9eb8");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("72cdb154-f7bf-4ca2-adba-360344f8cb3a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b9d46eb-00b3-4cac-bcaa-41efbf437c90", "AQAAAAEAACcQAAAAENA/Vjavwyx6cX3sKdiHhZbEL2GmPgrzDTDa2gBW3OmenoLp7PGBbtHUoGZppm83qg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 12, 24, 21, 35, 22, 21, DateTimeKind.Local).AddTicks(1809));
        }
    }
}
