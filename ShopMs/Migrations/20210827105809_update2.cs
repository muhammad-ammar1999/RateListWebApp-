using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopMs.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "SalesReport");

            migrationBuilder.AlterColumn<string>(
                name: "DName",
                table: "SalesReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesReport",
                table: "SalesReport",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesReport",
                table: "SalesReport");

            migrationBuilder.RenameTable(
                name: "SalesReport",
                newName: "Sales");

            migrationBuilder.AlterColumn<string>(
                name: "DName",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");
        }
    }
}
