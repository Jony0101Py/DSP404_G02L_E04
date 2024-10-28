using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafio_03.Migrations
{
    public partial class AddRoleToUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conciertos",
                columns: table => new
                {
                    ConciertoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Lugar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conciertos", x => x.ConciertoID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Secciones",
                columns: table => new
                {
                    SeccionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConciertoID = table.Column<int>(type: "int", nullable: false),
                    NombreSeccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Seccione__18B61621A0B9F74A", x => x.SeccionID);
                    table.ForeignKey(
                        name: "FK_Concierto_Secciones",
                        column: x => x.ConciertoID,
                        principalTable: "Conciertos",
                        principalColumn: "ConciertoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    EntradaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    SeccionID = table.Column<int>(type: "int", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.EntradaID);
                    table.ForeignKey(
                        name: "FK_Seccion_Entradas",
                        column: x => x.SeccionID,
                        principalTable: "Secciones",
                        principalColumn: "SeccionID");
                    table.ForeignKey(
                        name: "FK_Usuario_Entradas",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID");
                });

            migrationBuilder.CreateTable(
                name: "HistorialCompras",
                columns: table => new
                {
                    HistorialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    EntradaID = table.Column<int>(type: "int", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Historia__975206EF0EB9ED47", x => x.HistorialID);
                    table.ForeignKey(
                        name: "FK_Entrada_Historial",
                        column: x => x.EntradaID,
                        principalTable: "Entradas",
                        principalColumn: "EntradaID");
                    table.ForeignKey(
                        name: "FK_Usuario_Historial",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_SeccionID",
                table: "Entradas",
                column: "SeccionID");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_UsuarioID",
                table: "Entradas",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCompras_EntradaID",
                table: "HistorialCompras",
                column: "EntradaID");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCompras_UsuarioID",
                table: "HistorialCompras",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Secciones_ConciertoID",
                table: "Secciones",
                column: "ConciertoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialCompras");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Secciones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Conciertos");
        }
    }
}
