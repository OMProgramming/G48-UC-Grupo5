using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaTIC.App.Persistencia.Migrations
{
    public partial class SecondModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Ingredientes_HamburgesaId",
                table: "Ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_Ingredientes_PastelId",
                table: "Ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_Ingredientes_PerroId",
                table: "Ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_Ingredientes_PizzaId",
                table: "Ingredientes");

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

            migrationBuilder.DropColumn(
                name: "HamburgesaId",
                table: "Ingredientes");

            migrationBuilder.DropColumn(
                name: "PastelId",
                table: "Ingredientes");

            migrationBuilder.DropColumn(
                name: "PerroId",
                table: "Ingredientes");

            migrationBuilder.RenameColumn(
                name: "PizzaId",
                table: "Ingredientes",
                newName: "Calorias");

            migrationBuilder.AddColumn<string>(
                name: "TipoIngrediente",
                table: "Ingredientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Combo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComboNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ComboDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INVProductoCodigo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    INVProductoNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvProductos", x => x.Id);
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
                    AcompanamientoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AcompanamientoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acompanamientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Acompanamientos_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Acompanamientos_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BebidasCalientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BebidaCalienteoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BebidaCalienteDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BebidasCalientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BebidasCalientes_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BebidasCalientes_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Galletas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalletaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GalletaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galletas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galletas_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Galletas_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hamburgesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HamburgesaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HamburgesaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamburgesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hamburgesas_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hamburgesas_ComidaTamanos_comidaTamanoId",
                        column: x => x.comidaTamanoId,
                        principalTable: "ComidaTamanos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Helados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeladoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HeladoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Helados_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Helados_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JugosNaturales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JugoNaturalNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    JugoNaturalDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JugosNaturales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JugosNaturales_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JugosNaturales_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pasteles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PastelNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PastelDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasteles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pasteles_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pasteles_ComidaTamanos_comidaTamanoId",
                        column: x => x.comidaTamanoId,
                        principalTable: "ComidaTamanos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerroNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PerroDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perros_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Perros_ComidaTamanos_comidaTamanoId",
                        column: x => x.comidaTamanoId,
                        principalTable: "ComidaTamanos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PizzaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pizzas_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pizzas_ComidaTamanos_comidaTamanoId",
                        column: x => x.comidaTamanoId,
                        principalTable: "ComidaTamanos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Postres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostreNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostreDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postres_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Postres_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Refrescos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefrescoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RefrescoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refrescos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refrescos_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refrescos_Especificaciones_especificacionId",
                        column: x => x.especificacionId,
                        principalTable: "Especificaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ComboInvProducto",
                columns: table => new
                {
                    ComboId = table.Column<int>(type: "int", nullable: false),
                    InvProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboInvProducto", x => new { x.ComboId, x.InvProductosId });
                    table.ForeignKey(
                        name: "FK_ComboInvProducto_Combo_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboInvProducto_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvLineaDeProductoInvProducto",
                columns: table => new
                {
                    InvLineaDeProductosId = table.Column<int>(type: "int", nullable: false),
                    InvProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvLineaDeProductoInvProducto", x => new { x.InvLineaDeProductosId, x.InvProductosId });
                    table.ForeignKey(
                        name: "FK_InvLineaDeProductoInvProducto_InvLineaDeProductos_InvLineaDeProductosId",
                        column: x => x.InvLineaDeProductosId,
                        principalTable: "InvLineaDeProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvLineaDeProductoInvProducto_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcompanamientoInvProducto",
                columns: table => new
                {
                    AcompanamientosId = table.Column<int>(type: "int", nullable: false),
                    InvProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcompanamientoInvProducto", x => new { x.AcompanamientosId, x.InvProductosId });
                    table.ForeignKey(
                        name: "FK_AcompanamientoInvProducto_Acompanamientos_AcompanamientosId",
                        column: x => x.AcompanamientosId,
                        principalTable: "Acompanamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanamientoInvProducto_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BebidaCalienteInvProducto",
                columns: table => new
                {
                    BebidasCalientesId = table.Column<int>(type: "int", nullable: false),
                    InvProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BebidaCalienteInvProducto", x => new { x.BebidasCalientesId, x.InvProductosId });
                    table.ForeignKey(
                        name: "FK_BebidaCalienteInvProducto_BebidasCalientes_BebidasCalientesId",
                        column: x => x.BebidasCalientesId,
                        principalTable: "BebidasCalientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BebidaCalienteInvProducto_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GalletaInvProducto",
                columns: table => new
                {
                    GalletasId = table.Column<int>(type: "int", nullable: false),
                    InvProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalletaInvProducto", x => new { x.GalletasId, x.InvProductosId });
                    table.ForeignKey(
                        name: "FK_GalletaInvProducto_Galletas_GalletasId",
                        column: x => x.GalletasId,
                        principalTable: "Galletas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalletaInvProducto_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HamburgesaIngrediente",
                columns: table => new
                {
                    HamburgesasId = table.Column<int>(type: "int", nullable: false),
                    IngredientesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HamburgesaIngrediente", x => new { x.HamburgesasId, x.IngredientesId });
                    table.ForeignKey(
                        name: "FK_HamburgesaIngrediente_Hamburgesas_HamburgesasId",
                        column: x => x.HamburgesasId,
                        principalTable: "Hamburgesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HamburgesaIngrediente_Ingredientes_IngredientesId",
                        column: x => x.IngredientesId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HamburgesaInvProducto",
                columns: table => new
                {
                    HamburgesasId = table.Column<int>(type: "int", nullable: false),
                    InvProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HamburgesaInvProducto", x => new { x.HamburgesasId, x.InvProductosId });
                    table.ForeignKey(
                        name: "FK_HamburgesaInvProducto_Hamburgesas_HamburgesasId",
                        column: x => x.HamburgesasId,
                        principalTable: "Hamburgesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HamburgesaInvProducto_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeladoInvProducto",
                columns: table => new
                {
                    HeladosId = table.Column<int>(type: "int", nullable: false),
                    InvProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeladoInvProducto", x => new { x.HeladosId, x.InvProductosId });
                    table.ForeignKey(
                        name: "FK_HeladoInvProducto_Helados_HeladosId",
                        column: x => x.HeladosId,
                        principalTable: "Helados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeladoInvProducto_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvProductoJugoNatural",
                columns: table => new
                {
                    InvProductosId = table.Column<int>(type: "int", nullable: false),
                    JugosNaturalesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvProductoJugoNatural", x => new { x.InvProductosId, x.JugosNaturalesId });
                    table.ForeignKey(
                        name: "FK_InvProductoJugoNatural_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvProductoJugoNatural_JugosNaturales_JugosNaturalesId",
                        column: x => x.JugosNaturalesId,
                        principalTable: "JugosNaturales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientePastel",
                columns: table => new
                {
                    IngredientesId = table.Column<int>(type: "int", nullable: false),
                    PastelsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientePastel", x => new { x.IngredientesId, x.PastelsId });
                    table.ForeignKey(
                        name: "FK_IngredientePastel_Ingredientes_IngredientesId",
                        column: x => x.IngredientesId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientePastel_Pasteles_PastelsId",
                        column: x => x.PastelsId,
                        principalTable: "Pasteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvProductoPastel",
                columns: table => new
                {
                    InvProductosId = table.Column<int>(type: "int", nullable: false),
                    PastelesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvProductoPastel", x => new { x.InvProductosId, x.PastelesId });
                    table.ForeignKey(
                        name: "FK_InvProductoPastel_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvProductoPastel_Pasteles_PastelesId",
                        column: x => x.PastelesId,
                        principalTable: "Pasteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientePerro",
                columns: table => new
                {
                    IngredientesId = table.Column<int>(type: "int", nullable: false),
                    PerrosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientePerro", x => new { x.IngredientesId, x.PerrosId });
                    table.ForeignKey(
                        name: "FK_IngredientePerro_Ingredientes_IngredientesId",
                        column: x => x.IngredientesId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientePerro_Perros_PerrosId",
                        column: x => x.PerrosId,
                        principalTable: "Perros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvProductoPerro",
                columns: table => new
                {
                    InvProductosId = table.Column<int>(type: "int", nullable: false),
                    PerrosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvProductoPerro", x => new { x.InvProductosId, x.PerrosId });
                    table.ForeignKey(
                        name: "FK_InvProductoPerro_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvProductoPerro_Perros_PerrosId",
                        column: x => x.PerrosId,
                        principalTable: "Perros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientePizza",
                columns: table => new
                {
                    IngredientesId = table.Column<int>(type: "int", nullable: false),
                    PizzasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientePizza", x => new { x.IngredientesId, x.PizzasId });
                    table.ForeignKey(
                        name: "FK_IngredientePizza_Ingredientes_IngredientesId",
                        column: x => x.IngredientesId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientePizza_Pizzas_PizzasId",
                        column: x => x.PizzasId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvProductoPizza",
                columns: table => new
                {
                    InvProductosId = table.Column<int>(type: "int", nullable: false),
                    PizzasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvProductoPizza", x => new { x.InvProductosId, x.PizzasId });
                    table.ForeignKey(
                        name: "FK_InvProductoPizza_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvProductoPizza_Pizzas_PizzasId",
                        column: x => x.PizzasId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvProductoPostre",
                columns: table => new
                {
                    InvProductosId = table.Column<int>(type: "int", nullable: false),
                    PostresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvProductoPostre", x => new { x.InvProductosId, x.PostresId });
                    table.ForeignKey(
                        name: "FK_InvProductoPostre_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvProductoPostre_Postres_PostresId",
                        column: x => x.PostresId,
                        principalTable: "Postres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvProductoRefresco",
                columns: table => new
                {
                    InvProductosId = table.Column<int>(type: "int", nullable: false),
                    RefrescosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvProductoRefresco", x => new { x.InvProductosId, x.RefrescosId });
                    table.ForeignKey(
                        name: "FK_InvProductoRefresco_InvProductos_InvProductosId",
                        column: x => x.InvProductosId,
                        principalTable: "InvProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvProductoRefresco_Refrescos_RefrescosId",
                        column: x => x.RefrescosId,
                        principalTable: "Refrescos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcompanamientoInvProducto_InvProductosId",
                table: "AcompanamientoInvProducto",
                column: "InvProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanamientos_ComboId",
                table: "Acompanamientos",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Acompanamientos_especificacionId",
                table: "Acompanamientos",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_BebidaCalienteInvProducto_InvProductosId",
                table: "BebidaCalienteInvProducto",
                column: "InvProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_BebidasCalientes_ComboId",
                table: "BebidasCalientes",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_BebidasCalientes_especificacionId",
                table: "BebidasCalientes",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ComboInvProducto_InvProductosId",
                table: "ComboInvProducto",
                column: "InvProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_GalletaInvProducto_InvProductosId",
                table: "GalletaInvProducto",
                column: "InvProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_Galletas_ComboId",
                table: "Galletas",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Galletas_especificacionId",
                table: "Galletas",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_HamburgesaIngrediente_IngredientesId",
                table: "HamburgesaIngrediente",
                column: "IngredientesId");

            migrationBuilder.CreateIndex(
                name: "IX_HamburgesaInvProducto_InvProductosId",
                table: "HamburgesaInvProducto",
                column: "InvProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_Hamburgesas_ComboId",
                table: "Hamburgesas",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Hamburgesas_comidaTamanoId",
                table: "Hamburgesas",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_HeladoInvProducto_InvProductosId",
                table: "HeladoInvProducto",
                column: "InvProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_Helados_ComboId",
                table: "Helados",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Helados_especificacionId",
                table: "Helados",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientePastel_PastelsId",
                table: "IngredientePastel",
                column: "PastelsId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientePerro_PerrosId",
                table: "IngredientePerro",
                column: "PerrosId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientePizza_PizzasId",
                table: "IngredientePizza",
                column: "PizzasId");

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductoInvProducto_InvProductosId",
                table: "InvLineaDeProductoInvProducto",
                column: "InvProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductoJugoNatural_JugosNaturalesId",
                table: "InvProductoJugoNatural",
                column: "JugosNaturalesId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductoPastel_PastelesId",
                table: "InvProductoPastel",
                column: "PastelesId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductoPerro_PerrosId",
                table: "InvProductoPerro",
                column: "PerrosId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductoPizza_PizzasId",
                table: "InvProductoPizza",
                column: "PizzasId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductoPostre_PostresId",
                table: "InvProductoPostre",
                column: "PostresId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductoRefresco_RefrescosId",
                table: "InvProductoRefresco",
                column: "RefrescosId");

            migrationBuilder.CreateIndex(
                name: "IX_InvProductos_ProductoId",
                table: "InvProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_JugosNaturales_ComboId",
                table: "JugosNaturales",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_JugosNaturales_especificacionId",
                table: "JugosNaturales",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasteles_ComboId",
                table: "Pasteles",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasteles_comidaTamanoId",
                table: "Pasteles",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perros_ComboId",
                table: "Perros",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Perros_comidaTamanoId",
                table: "Perros",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_ComboId",
                table: "Pizzas",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_comidaTamanoId",
                table: "Pizzas",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Postres_ComboId",
                table: "Postres",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Postres_especificacionId",
                table: "Postres",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Refrescos_ComboId",
                table: "Refrescos",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Refrescos_especificacionId",
                table: "Refrescos",
                column: "especificacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcompanamientoInvProducto");

            migrationBuilder.DropTable(
                name: "BebidaCalienteInvProducto");

            migrationBuilder.DropTable(
                name: "ComboInvProducto");

            migrationBuilder.DropTable(
                name: "GalletaInvProducto");

            migrationBuilder.DropTable(
                name: "HamburgesaIngrediente");

            migrationBuilder.DropTable(
                name: "HamburgesaInvProducto");

            migrationBuilder.DropTable(
                name: "HeladoInvProducto");

            migrationBuilder.DropTable(
                name: "IngredientePastel");

            migrationBuilder.DropTable(
                name: "IngredientePerro");

            migrationBuilder.DropTable(
                name: "IngredientePizza");

            migrationBuilder.DropTable(
                name: "InvLineaDeProductoInvProducto");

            migrationBuilder.DropTable(
                name: "InvProductoJugoNatural");

            migrationBuilder.DropTable(
                name: "InvProductoPastel");

            migrationBuilder.DropTable(
                name: "InvProductoPerro");

            migrationBuilder.DropTable(
                name: "InvProductoPizza");

            migrationBuilder.DropTable(
                name: "InvProductoPostre");

            migrationBuilder.DropTable(
                name: "InvProductoRefresco");

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
                name: "InvProductos");

            migrationBuilder.DropTable(
                name: "Refrescos");

            migrationBuilder.DropTable(
                name: "Combo");

            migrationBuilder.DropColumn(
                name: "TipoIngrediente",
                table: "Ingredientes");

            migrationBuilder.RenameColumn(
                name: "Calorias",
                table: "Ingredientes",
                newName: "PizzaId");

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

            migrationBuilder.AddColumn<int>(
                name: "HamburgesaId",
                table: "Ingredientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PastelId",
                table: "Ingredientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerroId",
                table: "Ingredientes",
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

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_HamburgesaId",
                table: "Ingredientes",
                column: "HamburgesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_PastelId",
                table: "Ingredientes",
                column: "PastelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_PerroId",
                table: "Ingredientes",
                column: "PerroId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_PizzaId",
                table: "Ingredientes",
                column: "PizzaId");

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
    }
}
