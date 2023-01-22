using Microsoft.EntityFrameworkCore.Migrations;

namespace SiteRepublicas.Migrations
{
    public partial class contat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Republicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Quartos = table.Column<int>(nullable: false),
                    Salas = table.Column<int>(nullable: false),
                    Banheiros = table.Column<int>(nullable: false),
                    Cozinha = table.Column<int>(nullable: false),
                    Numero_de_Vagas = table.Column<int>(nullable: false),
                    Garagem = table.Column<int>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Republicas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Republicas");
        }
    }
}
