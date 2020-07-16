using Microsoft.EntityFrameworkCore.Migrations;

namespace ChickenStore.DataAccess.Migrations
{
    public partial class ProductRevampforChickens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CoverTypes_CoverTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CoverTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CoverTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ListPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price100",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price50",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Products",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CoverTypeId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ListPrice",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price100",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price50",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverTypeId",
                table: "Products",
                column: "CoverTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CoverTypes_CoverTypeId",
                table: "Products",
                column: "CoverTypeId",
                principalTable: "CoverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
