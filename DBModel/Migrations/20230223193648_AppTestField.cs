using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBModel.Migrations
{
    public partial class AppTestField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewField",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewField",
                table: "AspNetUsers");
        }
    }
}
