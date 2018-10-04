using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CDX.Totem.Domain.Migrations
{
    public partial class _011020181 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "LogEvento",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: true),
                    LogLevel = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEvento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotemConfig",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    Situacao = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    Codigo = table.Column<string>(maxLength: 10, nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    FusoHorario = table.Column<int>(nullable: false),
                    Versao = table.Column<string>(maxLength: 20, nullable: true),
                    Contratante = table.Column<string>(maxLength: 20, nullable: true),
                    Estabelecimento = table.Column<string>(maxLength: 20, nullable: true),
                    Serial = table.Column<string>(maxLength: 50, nullable: true),
                    InformativoH1 = table.Column<string>(maxLength: 80, nullable: true),
                    InformativoH2 = table.Column<string>(maxLength: 80, nullable: true),
                    InformativoH3 = table.Column<string>(maxLength: 80, nullable: true),
                    ChaveAcessoSinPag = table.Column<string>(maxLength: 20, nullable: true),
                    Logotipo = table.Column<string>(maxLength: 50, nullable: true),
                    Logado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotemConfig", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogEvento",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TotemConfig",
                schema: "dbo");
        }
    }
}
