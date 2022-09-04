using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaTIC.App.Persistencia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NivelDeAcceso = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComidaTamanos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComidaTamanoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumeroIngredientes = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Ancho = table.Column<int>(type: "int", nullable: false),
                    Largo = table.Column<int>(type: "int", nullable: false),
                    Alto = table.Column<int>(type: "int", nullable: false),
                    TipoEmpaque = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComidaTamanos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Ancho = table.Column<int>(type: "int", nullable: false),
                    Largo = table.Column<int>(type: "int", nullable: false),
                    Alto = table.Column<int>(type: "int", nullable: false),
                    TipoEmpaque = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especificaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormasDePagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeTarjeta = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NombreEnTarjeta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeroEnTarjeta = table.Column<double>(type: "float", maxLength: 16, nullable: false),
                    FechaDeVencimiento = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    CodigoDeSeguridad = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasDePagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Departamento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    formaDePagoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_FormasDePagos_formaDePagoId",
                        column: x => x.formaDePagoId,
                        principalTable: "FormasDePagos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDePago = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: true),
                    PagoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Factura = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    formaDePagoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_FormasDePagos_formaDePagoId",
                        column: x => x.formaDePagoId,
                        principalTable: "FormasDePagos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Envios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDeEnvio = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: true),
                    DireccionFacturacion = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Finalizado = table.Column<bool>(type: "bit", nullable: false),
                    CompaniaTransporte = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    pagoId = table.Column<int>(type: "int", nullable: true),
                    envioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Envios_Envios_envioId",
                        column: x => x.envioId,
                        principalTable: "Envios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Envios_Pagos_pagoId",
                        column: x => x.pagoId,
                        principalTable: "Pagos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDeRealizacion = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    pagoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Pagos_pagoId",
                        column: x => x.pagoId,
                        principalTable: "Pagos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarritosDeCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: true),
                    pedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritosDeCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarritosDeCompras_Pedidos_pedidoId",
                        column: x => x.pedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClientePedido",
                columns: table => new
                {
                    ClientesId = table.Column<int>(type: "int", nullable: false),
                    PedidosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientePedido", x => new { x.ClientesId, x.PedidosId });
                    table.ForeignKey(
                        name: "FK_ClientePedido_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientePedido_Pedidos_PedidosId",
                        column: x => x.PedidosId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineasDeProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    PrecioLP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    carritoDeCompraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasDeProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineasDeProductos_CarritosDeCompras_carritoDeCompraId",
                        column: x => x.carritoDeCompraId,
                        principalTable: "CarritosDeCompras",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InvLineaDeProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INVLPCodigo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    INVLPNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LineaDeProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvLineaDeProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvLineaDeProductos_LineasDeProductos_LineaDeProductoId",
                        column: x => x.LineaDeProductoId,
                        principalTable: "LineasDeProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LineaDeProductoPedido",
                columns: table => new
                {
                    LineaDeProductosId = table.Column<int>(type: "int", nullable: false),
                    PedidosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineaDeProductoPedido", x => new { x.LineaDeProductosId, x.PedidosId });
                    table.ForeignKey(
                        name: "FK_LineaDeProductoPedido_LineasDeProductos_LineaDeProductosId",
                        column: x => x.LineaDeProductosId,
                        principalTable: "LineasDeProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineaDeProductoPedido_Pedidos_PedidosId",
                        column: x => x.PedidosId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LineaDeProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_LineasDeProductos_LineaDeProductoId",
                        column: x => x.LineaDeProductoId,
                        principalTable: "LineasDeProductos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InvProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INVProductoCodigo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    INVProductoNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Combo = table.Column<bool>(type: "bit", nullable: true),
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
                    AcompanamientoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AcompanamientoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
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
                    BebidaCalienteoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BebidaCalienteDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
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
                    GalletaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GalletaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
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
                    HamburgesaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HamburgesaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
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
                    HeladoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HeladoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
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
                    JugoNaturalNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    JugoNaturalDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
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
                    PastelNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PastelDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
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
                    PerroNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PerroDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
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
                    PizzaNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PizzaDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    comidaTamanoId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
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
                    PostreNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostreDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
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
                    RefrescoNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RefrescoDescripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    especificacionId = table.Column<int>(type: "int", nullable: true),
                    InvProductoId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreIngrediente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HamburgesaId = table.Column<int>(type: "int", nullable: true),
                    PastelId = table.Column<int>(type: "int", nullable: true),
                    PerroId = table.Column<int>(type: "int", nullable: true),
                    PizzaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredientes_Hamburgesas_HamburgesaId",
                        column: x => x.HamburgesaId,
                        principalTable: "Hamburgesas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredientes_Pasteles_PastelId",
                        column: x => x.PastelId,
                        principalTable: "Pasteles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredientes_Perros_PerroId",
                        column: x => x.PerroId,
                        principalTable: "Perros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredientes_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
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
                name: "IX_CarritosDeCompras_pedidoId",
                table: "CarritosDeCompras",
                column: "pedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientePedido_PedidosId",
                table: "ClientePedido",
                column: "PedidosId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_formaDePagoId",
                table: "Clientes",
                column: "formaDePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_envioId",
                table: "Envios",
                column: "envioId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_pagoId",
                table: "Envios",
                column: "pagoId");

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

            migrationBuilder.CreateIndex(
                name: "IX_InvLineaDeProductos_LineaDeProductoId",
                table: "InvLineaDeProductos",
                column: "LineaDeProductoId");

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
                name: "IX_LineaDeProductoPedido_PedidosId",
                table: "LineaDeProductoPedido",
                column: "PedidosId");

            migrationBuilder.CreateIndex(
                name: "IX_LineasDeProductos_carritoDeCompraId",
                table: "LineasDeProductos",
                column: "carritoDeCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_formaDePagoId",
                table: "Pagos",
                column: "formaDePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasteles_comidaTamanoId",
                table: "Pasteles",
                column: "comidaTamanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasteles_InvProductoId",
                table: "Pasteles",
                column: "InvProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_pagoId",
                table: "Pedidos",
                column: "pagoId");

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
                name: "IX_Productos_LineaDeProductoId",
                table: "Productos",
                column: "LineaDeProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Refrescos_especificacionId",
                table: "Refrescos",
                column: "especificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Refrescos_InvProductoId",
                table: "Refrescos",
                column: "InvProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acompanamientos");

            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "BebidasCalientes");

            migrationBuilder.DropTable(
                name: "ClientePedido");

            migrationBuilder.DropTable(
                name: "Envios");

            migrationBuilder.DropTable(
                name: "Galletas");

            migrationBuilder.DropTable(
                name: "Helados");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "JugosNaturales");

            migrationBuilder.DropTable(
                name: "LineaDeProductoPedido");

            migrationBuilder.DropTable(
                name: "Postres");

            migrationBuilder.DropTable(
                name: "Refrescos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Hamburgesas");

            migrationBuilder.DropTable(
                name: "Pasteles");

            migrationBuilder.DropTable(
                name: "Perros");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Especificaciones");

            migrationBuilder.DropTable(
                name: "ComidaTamanos");

            migrationBuilder.DropTable(
                name: "InvProductos");

            migrationBuilder.DropTable(
                name: "InvLineaDeProductos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "LineasDeProductos");

            migrationBuilder.DropTable(
                name: "CarritosDeCompras");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "FormasDePagos");
        }
    }
}
