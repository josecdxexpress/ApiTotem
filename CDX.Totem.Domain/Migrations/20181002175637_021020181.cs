using Microsoft.EntityFrameworkCore.Migrations;

namespace CDX.Totem.Domain.Migrations
{
    public partial class _021020181 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LimiteInatividade",
                schema: "dbo",
                table: "TotemConfig",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LimiteInatividade",
                schema: "dbo",
                table: "TotemConfig");
        }
    }
}
