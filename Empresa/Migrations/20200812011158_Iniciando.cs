using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Empresa.Migrations
{
    public partial class Iniciando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EMP_BILLINGS",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    free = table.Column<bool>(nullable: false),
                    database = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_BILLINGS", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EMP_EXTRA",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_EXTRA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EMP_PRINCIPAL",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_situacao = table.Column<string>(maxLength: 20, nullable: true),
                    complemento = table.Column<string>(maxLength: 100, nullable: true),
                    nome = table.Column<string>(maxLength: 250, nullable: true),
                    uf = table.Column<string>(maxLength: 2, nullable: true),
                    telefone = table.Column<string>(maxLength: 11, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    situacao = table.Column<string>(maxLength: 100, nullable: true),
                    bairro = table.Column<string>(maxLength: 100, nullable: true),
                    logradouro = table.Column<string>(maxLength: 200, nullable: true),
                    numero = table.Column<string>(maxLength: 15, nullable: true),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    municipio = table.Column<string>(maxLength: 150, nullable: true),
                    porte = table.Column<string>(maxLength: 150, nullable: true),
                    abertura = table.Column<string>(maxLength: 100, nullable: true),
                    natureza_juridica = table.Column<string>(maxLength: 150, nullable: true),
                    cnpj = table.Column<string>(maxLength: 14, nullable: true),
                    ultima_atualizacao = table.Column<DateTime>(nullable: false),
                    tipo = table.Column<string>(maxLength: 10, nullable: true),
                    fantasia = table.Column<string>(maxLength: 200, nullable: true),
                    efr = table.Column<string>(maxLength: 20, nullable: true),
                    motivo_situacao = table.Column<string>(maxLength: 150, nullable: true),
                    data_situacao_especial = table.Column<string>(maxLength: 100, nullable: true),
                    capital_social = table.Column<string>(maxLength: 100, nullable: true),
                    extraid = table.Column<int>(nullable: false),
                    billingid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_PRINCIPAL", x => x.id);
                    table.ForeignKey(
                        name: "FK_EMP_PRINCIPAL_EMP_BILLINGS_billingid",
                        column: x => x.billingid,
                        principalTable: "EMP_BILLINGS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EMP_PRINCIPAL_EMP_EXTRA_extraid",
                        column: x => x.extraid,
                        principalTable: "EMP_EXTRA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMP_ATVPRINCIPAL",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(maxLength: 200, nullable: true),
                    code = table.Column<string>(maxLength: 100, nullable: true),
                    empresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_ATVPRINCIPAL", x => x.id);
                    table.ForeignKey(
                        name: "FK_EMP_ATVPRINCIPAL_EMP_PRINCIPAL_empresaId",
                        column: x => x.empresaId,
                        principalTable: "EMP_PRINCIPAL",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMP_ATVSECUNDARIAS",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(maxLength: 200, nullable: true),
                    code = table.Column<string>(maxLength: 100, nullable: true),
                    empresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_ATVSECUNDARIAS", x => x.id);
                    table.ForeignKey(
                        name: "FK_EMP_ATVSECUNDARIAS_EMP_PRINCIPAL_empresaId",
                        column: x => x.empresaId,
                        principalTable: "EMP_PRINCIPAL",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMP_SOCIO",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qual = table.Column<string>(nullable: true),
                    qual_rep_legal = table.Column<string>(nullable: true),
                    nome_rep_legal = table.Column<string>(nullable: true),
                    nome = table.Column<string>(nullable: true),
                    empresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_SOCIO", x => x.id);
                    table.ForeignKey(
                        name: "FK_EMP_SOCIO_EMP_PRINCIPAL_empresaId",
                        column: x => x.empresaId,
                        principalTable: "EMP_PRINCIPAL",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EMP_ATVPRINCIPAL_empresaId",
                table: "EMP_ATVPRINCIPAL",
                column: "empresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EMP_ATVSECUNDARIAS_empresaId",
                table: "EMP_ATVSECUNDARIAS",
                column: "empresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EMP_PRINCIPAL_billingid",
                table: "EMP_PRINCIPAL",
                column: "billingid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EMP_PRINCIPAL_extraid",
                table: "EMP_PRINCIPAL",
                column: "extraid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EMP_SOCIO_empresaId",
                table: "EMP_SOCIO",
                column: "empresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EMP_ATVPRINCIPAL");

            migrationBuilder.DropTable(
                name: "EMP_ATVSECUNDARIAS");

            migrationBuilder.DropTable(
                name: "EMP_SOCIO");

            migrationBuilder.DropTable(
                name: "EMP_PRINCIPAL");

            migrationBuilder.DropTable(
                name: "EMP_BILLINGS");

            migrationBuilder.DropTable(
                name: "EMP_EXTRA");
        }
    }
}
