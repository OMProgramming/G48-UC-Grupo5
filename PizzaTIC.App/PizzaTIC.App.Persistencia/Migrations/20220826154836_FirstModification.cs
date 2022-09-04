using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaTIC.App.Persistencia.Migrations
{
    public partial class FirstModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_Hamburgesas_HamburgesaId",
                table: "Ingredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_Pasteles_PastelId",
                table: "Ingredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_Perros_PerroId",
                table: "Ingredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_Pizzas_PizzaId",
                table: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Acompanamientos");

            migrationBuilder.DropTable(
                name: "BebidasCalientes");

            migrationBuilder.DropTable(
                name: "Galletas");

            migrationBuilder.DropTable(
                name: "Hamburgesas");

            migrationBuilder.DropTable(
                name: "Helados");

            migrationBuilder.DropTable(
                name: "JugosNaturales");

            migrationBuilder.DropTable(
                name: "Pasteles");

            migrationBuilder.DropTable(
                name: "Perros");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Postres");

            migrationBuilder.DropTable(
                name: "Refrescos");

            migrationBuilder.DropTable(
                name: "InvProductos");

            migrationBuilder.AddColumn<string>(
                name: "AcompanamientoDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcompanamientoNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Acompanamiento_especificacionId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BebidaCalienteDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BebidaCaliente_especificacionId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BebidaCalienteoNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Combo",
                table: "InvLineaDeProductos",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "InvLineaDeProductos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GalletaDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalletaNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Galleta_especificacionId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HamburgesaDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HamburgesaNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeladoDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeladoNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INVProductoCodigo",
                table: "InvLineaDeProductos",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INVProductoNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvLineaDeProductoId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JugoNaturalDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JugoNaturalNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JugoNatural_especificacionId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastelDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastelNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pastel_comidaTamanoId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PerroDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PerroNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Perro_comidaTamanoId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PizzaDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PizzaNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pizza_comidaTamanoId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostreDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostreNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Postre_especificacionId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefrescoDescripcion",
                table: "InvLineaDeProductos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefrescoNombre",
                table: "InvLineaDeProductos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Refresco_especificacionId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "comidaTamanoId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "especificacionId",
                table: "InvLineaDeProductos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_Acompanamiento_especificacionId",
                table: "InvLineaDeProductos",
                column: "Acompanamiento_especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_BebidaCaliente_especificacionId",
                table: "InvLineaDeProductos",
                column: "BebidaCaliente_especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_comidaTamanoId",
                table: "InvLineaDeProductos",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_especificacionId",
                table: "InvLineaDeProductos",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_Galleta_especificacionId",
                table: "InvLineaDeProductos",
                column: "Galleta_especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_InvLineaDeProductoId",
                table: "InvLineaDeProductos",
                column: "InvLineaDeProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_JugoNatural_especificacionId",
                table: "InvLineaDeProductos",
                column: "JugoNatural_especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_Pastel_comidaTamanoId",
                table: "InvLineaDeProductos",
                column: "Pastel_comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_Perro_comidaTamanoId",
                table: "InvLineaDeProductos",
                column: "Perro_comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_Pizza_comidaTamanoId",
                table: "InvLineaDeProductos",
                column: "Pizza_comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_Postre_especificacionId",
                table: "InvLineaDeProductos",
                column: "Postre_especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_ProductoId",
                table: "InvLineaDeProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_Refresco_especificacionId",
                table: "InvLineaDeProductos",
                column: "Refresco_especificacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_InvLineaDeProductos_HamburgesaId",
                table: "Ingredientes",
                column: "HamburgesaId",
                principalTable: "InvLineaDeProductos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_InvLineaDeProductos_PastelId",
                table: "Ingredientes",
                column: "PastelId",
                principalTable: "InvLineaDeProductos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_InvLineaDeProductos_PerroId",
                table: "Ingredientes",
                column: "PerroId",
                principalTable: "InvLineaDeProductos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_InvLineaDeProductos_PizzaId",
                table: "Ingredientes",
                column: "PizzaId",
                principalTable: "InvLineaDeProductos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_ComidaTamanos_comidaTamanoId",
                table: "InvLineaDeProductos",
                column: "comidaTamanoId",
                principalTable: "ComidaTamanos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_ComidaTamanos_Pastel_comidaTamanoId",
                table: "InvLineaDeProductos",
                column: "Pastel_comidaTamanoId",
                principalTable: "ComidaTamanos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_ComidaTamanos_Perro_comidaTamanoId",
                table: "InvLineaDeProductos",
                column: "Perro_comidaTamanoId",
                principalTable: "ComidaTamanos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_ComidaTamanos_Pizza_comidaTamanoId",
                table: "InvLineaDeProductos",
                column: "Pizza_comidaTamanoId",
                principalTable: "ComidaTamanos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_Acompanamiento_especificacionId",
                table: "InvLineaDeProductos",
                column: "Acompanamiento_especificacionId",
                principalTable: "Especificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_BebidaCaliente_especificacionId",
                table: "InvLineaDeProductos",
                column: "BebidaCaliente_especificacionId",
                principalTable: "Especificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_especificacionId",
                table: "InvLineaDeProductos",
                column: "especificacionId",
                principalTable: "Especificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_Galleta_especificacionId",
                table: "InvLineaDeProductos",
                column: "Galleta_especificacionId",
                principalTable: "Especificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_JugoNatural_especificacionId",
                table: "InvLineaDeProductos",
                column: "JugoNatural_especificacionId",
                principalTable: "Especificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_Postre_especificacionId",
                table: "InvLineaDeProductos",
                column: "Postre_especificacionId",
                principalTable: "Especificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_Refresco_especificacionId",
                table: "InvLineaDeProductos",
                column: "Refresco_especificacionId",
                principalTable: "Especificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_InvLineaDeProductos_InvLineaDeProductoId",
                table: "InvLineaDeProductos",
                column: "InvLineaDeProductoId",
                principalTable: "InvLineaDeProductos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvLineaDeProductos_Productos_ProductoId",
                table: "InvLineaDeProductos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_InvLineaDeProductos_HamburgesaId",
                table: "Ingredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_InvLineaDeProductos_PastelId",
                table: "Ingredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_InvLineaDeProductos_PerroId",
                table: "Ingredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_InvLineaDeProductos_PizzaId",
                table: "Ingredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_ComidaTamanos_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_ComidaTamanos_Pastel_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_ComidaTamanos_Perro_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_ComidaTamanos_Pizza_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_Acompanamiento_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_BebidaCaliente_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_Galleta_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_JugoNatural_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_Postre_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_Especificaciones_Refresco_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_InvLineaDeProductos_InvLineaDeProductoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvLineaDeProductos_Productos_ProductoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_Acompanamiento_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_BebidaCaliente_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_Galleta_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_InvLineaDeProductoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_JugoNatural_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_Pastel_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_Perro_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_Pizza_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_Postre_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_ProductoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropIndex(
                name: "IX_InvLineaDeProductos_Refresco_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "AcompanamientoDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "AcompanamientoNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Acompanamiento_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "BebidaCalienteDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "BebidaCaliente_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "BebidaCalienteoNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Combo",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "GalletaDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "GalletaNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Galleta_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "HamburgesaDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "HamburgesaNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "HeladoDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "HeladoNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "INVProductoCodigo",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "INVProductoNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "InvLineaDeProductoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "JugoNaturalDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "JugoNaturalNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "JugoNatural_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "PastelDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "PastelNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Pastel_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "PerroDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "PerroNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Perro_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "PizzaDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "PizzaNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Pizza_comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "PostreDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "PostreNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Postre_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "RefrescoDescripcion",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "RefrescoNombre",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "Refresco_especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "comidaTamanoId",
                table: "InvLineaDeProductos");

            migrationBuilder.DropColumn(
                name: "especificacionId",
                table: "InvLineaDeProductos");

            migrationBuilder.CreateTable(
                name: "InvProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Combo = table.Column<bool>(type: "bit", nullable: true),
                    INVProductoCodigo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    INVProductoNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    InvLineaDeProductoId = table.Column<int>(type: "int", nullable: true),
                    ProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvProductos_InvLineaDeProductos_InvLineaDeProductoId",
                        column: x => x.InvLineaDeProductoId,
                        principalTable: "InvLineaDeProductos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Acompanamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    AcompanamientoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AcompanamientoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acompanamientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Acompanamientos_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Acompanamientos_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BebidasCalientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    BebidaCalienteDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    BebidaCalienteoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BebidasCalientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BebidasCalientes_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BebidasCalientes_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Galletas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    GalletaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    GalletaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galletas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galletas_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Galletas_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hamburgesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    HamburgesaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    HamburgesaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamburgesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hamburgesas_ComidaTamanos_comidaTamanoId",
                        column: x => x.comidaTamanoId,
                        principalTable: "ComidaTamanos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hamburgesas_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Helados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    HeladoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    HeladoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Helados_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Helados_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JugosNaturales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true),
                    JugoNaturalDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    JugoNaturalNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JugosNaturales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JugosNaturales_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JugosNaturales_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pasteles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true),
                    PastelDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PastelNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasteles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pasteles_ComidaTamanos_comidaTamanoId",
                        column: x => x.comidaTamanoId,
                        principalTable: "ComidaTamanos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pasteles_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true),
                    PerroDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PerroNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perros_ComidaTamanos_comidaTamanoId",
                        column: x => x.comidaTamanoId,
                        principalTable: "ComidaTamanos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Perros_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true),
                    PizzaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PizzaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pizzas_ComidaTamanos_comidaTamanoId",
                        column: x => x.comidaTamanoId,
                        principalTable: "ComidaTamanos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pizzas_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Postres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true),
                    PostreDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PostreNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postres_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Postres_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Refrescos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true),
                    RefrescoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RefrescoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refrescos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refrescos_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refrescos_InvProductos_InvProductoId",
                        column: x => x.InvProductoId,
                        principalTable: "InvProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acompanamientos_especificacionId",
                table: "Acompanamientos",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanamientos_InvProductoId",
                table: "Acompanamientos",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_BebidasCalientes_especificacionId",
                table: "BebidasCalientes",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_BebidasCalientes_InvProductoId",
                table: "BebidasCalientes",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Galletas_especificacionId",
                table: "Galletas",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Galletas_InvProductoId",
                table: "Galletas",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Hamburgesas_comidaTamanoId",
                table: "Hamburgesas",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Hamburgesas_InvProductoId",
                table: "Hamburgesas",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Helados_especificacionId",
                table: "Helados",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Helados_InvProductoId",
                table: "Helados",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductos_InvLineaDeProductoId",
                table: "InvProductos",
                column: "InvLineaDeProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductos_ProductoId",
                table: "InvProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_JugosNaturales_especificacionId",
                table: "JugosNaturales",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_JugosNaturales_InvProductoId",
                table: "JugosNaturales",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasteles_comidaTamanoId",
                table: "Pasteles",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasteles_InvProductoId",
                table: "Pasteles",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perros_comidaTamanoId",
                table: "Perros",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perros_InvProductoId",
                table: "Perros",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_comidaTamanoId",
                table: "Pizzas",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_InvProductoId",
                table: "Pizzas",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Postres_especificacionId",
                table: "Postres",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Postres_InvProductoId",
                table: "Postres",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Refrescos_especificacionId",
                table: "Refrescos",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Refrescos_InvProductoId",
                table: "Refrescos",
                column: "InvProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_Hamburgesas_HamburgesaId",
                table: "Ingredientes",
                column: "HamburgesaId",
                principalTable: "Hamburgesas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_Pasteles_PastelId",
                table: "Ingredientes",
                column: "PastelId",
                principalTable: "Pasteles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_Perros_PerroId",
                table: "Ingredientes",
                column: "PerroId",
                principalTable: "Perros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_Pizzas_PizzaId",
                table: "Ingredientes",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id");
        }
    }
}
