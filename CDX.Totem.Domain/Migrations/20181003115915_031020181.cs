using Microsoft.EntityFrameworkCore.Migrations;

namespace CDX.Totem.Domain.Migrations
{
    public partial class _031020181 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AtendeDetran",
                schema: "dbo",
                table: "TotemConfig",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AtendePatios",
                schema: "dbo",
                table: "TotemConfig",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProgressBarTextoH1",
                schema: "dbo",
                table: "TotemConfig",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgressBarTextoH2",
                schema: "dbo",
                table: "TotemConfig",
                maxLength: 80,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtendeDetran",
                schema: "dbo",
                table: "TotemConfig");

            migrationBuilder.DropColumn(
                name: "AtendePatios",
                schema: "dbo",
                table: "TotemConfig");

            migrationBuilder.DropColumn(
                name: "ProgressBarTextoH1",
                schema: "dbo",
                table: "TotemConfig");

            migrationBuilder.DropColumn(
                name: "ProgressBarTextoH2",
                schema: "dbo",
                table: "TotemConfig");
        }
    }
}
