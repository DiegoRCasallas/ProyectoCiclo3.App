using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class Migrarutas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "numero_banos",
                table: "Aviones",
                newName: "Numero_banos");

            migrationBuilder.RenameColumn(
                name: "numero_asientos",
                table: "Aviones",
                newName: "Numero_asientos");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Aviones",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Aviones",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "capacidad_maxima",
                table: "Aviones",
                newName: "Capacidad_maxima");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Aviones",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.RenameColumn(
                name: "Numero_banos",
                table: "Aviones",
                newName: "numero_banos");

            migrationBuilder.RenameColumn(
                name: "Numero_asientos",
                table: "Aviones",
                newName: "numero_asientos");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Aviones",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Aviones",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "Capacidad_maxima",
                table: "Aviones",
                newName: "capacidad_maxima");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Aviones",
                newName: "id");
        }
    }
}
