﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaTIC.App.Persistencia;

#nullable disable

namespace PizzaTIC.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220826154836_FirstModification")]
    partial class FirstModification
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClientePedido", b =>
                {
                    b.Property<int>("ClientesId")
                        .HasColumnType("int");

                    b.Property<int>("PedidosId")
                        .HasColumnType("int");

                    b.HasKey("ClientesId", "PedidosId");

                    b.HasIndex("PedidosId");

                    b.ToTable("ClientePedido");
                });

            modelBuilder.Entity("LineaDeProductoPedido", b =>
                {
                    b.Property<int>("LineaDeProductosId")
                        .HasColumnType("int");

                    b.Property<int>("PedidosId")
                        .HasColumnType("int");

                    b.HasKey("LineaDeProductosId", "PedidosId");

                    b.HasIndex("PedidosId");

                    b.ToTable("LineaDeProductoPedido");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NivelDeAcceso")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.CarritoDeCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasMaxLength(30)
                        .HasColumnType("datetime2");

                    b.Property<int?>("pedidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("pedidoId");

                    b.ToTable("CarritosDeCompras");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("formaDePagoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("formaDePagoId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.ComidaTamano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Alto")
                        .HasColumnType("int");

                    b.Property<int>("Ancho")
                        .HasColumnType("int");

                    b.Property<string>("ComidaTamanoNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Largo")
                        .HasColumnType("int");

                    b.Property<int>("NumeroIngredientes")
                        .HasColumnType("int");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoEmpaque")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("ComidaTamanos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Envio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompaniaTransporte")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("DireccionFacturacion")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime?>("FechaDeEnvio")
                        .HasMaxLength(30)
                        .HasColumnType("datetime2");

                    b.Property<bool>("Finalizado")
                        .HasColumnType("bit");

                    b.Property<int?>("envioId")
                        .HasColumnType("int");

                    b.Property<int?>("pagoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("envioId");

                    b.HasIndex("pagoId");

                    b.ToTable("Envios");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Especificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Alto")
                        .HasColumnType("int");

                    b.Property<int>("Ancho")
                        .HasColumnType("int");

                    b.Property<int>("Largo")
                        .HasColumnType("int");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoEmpaque")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Especificaciones");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.FormaDePago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoDeSeguridad")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTime?>("FechaDeVencimiento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEnTarjeta")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("NumeroEnTarjeta")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("float");

                    b.Property<string>("TipoDeTarjeta")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("FormasDePagos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("HamburgesaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreIngrediente")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("PastelId")
                        .HasColumnType("int");

                    b.Property<int?>("PerroId")
                        .HasColumnType("int");

                    b.Property<int?>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HamburgesaId");

                    b.HasIndex("PastelId");

                    b.HasIndex("PerroId");

                    b.HasIndex("PizzaId");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.InvLineaDeProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INVLPCodigo")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("INVLPNombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("LineaDeProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LineaDeProductoId");

                    b.ToTable("InvLineaDeProductos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InvLineaDeProducto");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.LineaDeProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal?>("PrecioLP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("carritoDeCompraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("carritoDeCompraId");

                    b.ToTable("LineasDeProductos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Factura")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("FechaDePago")
                        .HasMaxLength(30)
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("PagoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("formaDePagoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("formaDePagoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("FechaDeRealizacion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("datetime2");

                    b.Property<int?>("pagoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("pagoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("LineaDeProductoId")
                        .HasColumnType("int");

                    b.Property<decimal?>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("LineaDeProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.InvProducto", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvLineaDeProducto");

                    b.Property<bool?>("Combo")
                        .HasColumnType("bit");

                    b.Property<string>("INVProductoCodigo")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("INVProductoNombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("InvLineaDeProductoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.HasIndex("InvLineaDeProductoId");

                    b.HasIndex("ProductoId");

                    b.HasDiscriminator().HasValue("InvProducto");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Acompanamiento", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("AcompanamientoDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("AcompanamientoNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("especificacionId")
                        .HasColumnType("int")
                        .HasColumnName("Acompanamiento_especificacionId");

                    b.HasIndex("especificacionId");

                    b.HasDiscriminator().HasValue("Acompanamiento");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.BebidaCaliente", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("BebidaCalienteDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("BebidaCalienteoNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("especificacionId")
                        .HasColumnType("int")
                        .HasColumnName("BebidaCaliente_especificacionId");

                    b.HasIndex("especificacionId");

                    b.HasDiscriminator().HasValue("BebidaCaliente");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Galleta", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("GalletaDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("GalletaNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("especificacionId")
                        .HasColumnType("int")
                        .HasColumnName("Galleta_especificacionId");

                    b.HasIndex("especificacionId");

                    b.HasDiscriminator().HasValue("Galleta");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Hamburgesa", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("HamburgesaDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("HamburgesaNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("comidaTamanoId")
                        .HasColumnType("int");

                    b.HasIndex("comidaTamanoId");

                    b.HasDiscriminator().HasValue("Hamburgesa");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Helado", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("HeladoDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("HeladoNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("especificacionId")
                        .HasColumnType("int");

                    b.HasIndex("especificacionId");

                    b.HasDiscriminator().HasValue("Helado");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.JugoNatural", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("JugoNaturalDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("JugoNaturalNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("especificacionId")
                        .HasColumnType("int")
                        .HasColumnName("JugoNatural_especificacionId");

                    b.HasIndex("especificacionId");

                    b.HasDiscriminator().HasValue("JugoNatural");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pastel", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("PastelDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PastelNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("comidaTamanoId")
                        .HasColumnType("int")
                        .HasColumnName("Pastel_comidaTamanoId");

                    b.HasIndex("comidaTamanoId");

                    b.HasDiscriminator().HasValue("Pastel");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Perro", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("PerroDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PerroNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("comidaTamanoId")
                        .HasColumnType("int")
                        .HasColumnName("Perro_comidaTamanoId");

                    b.HasIndex("comidaTamanoId");

                    b.HasDiscriminator().HasValue("Perro");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pizza", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("PizzaDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PizzaNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("comidaTamanoId")
                        .HasColumnType("int")
                        .HasColumnName("Pizza_comidaTamanoId");

                    b.HasIndex("comidaTamanoId");

                    b.HasDiscriminator().HasValue("Pizza");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Postre", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("PostreDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PostreNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("especificacionId")
                        .HasColumnType("int")
                        .HasColumnName("Postre_especificacionId");

                    b.HasIndex("especificacionId");

                    b.HasDiscriminator().HasValue("Postre");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Refresco", b =>
                {
                    b.HasBaseType("PizzaTIC.App.Dominio.InvProducto");

                    b.Property<string>("RefrescoDescripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("RefrescoNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("especificacionId")
                        .HasColumnType("int")
                        .HasColumnName("Refresco_especificacionId");

                    b.HasIndex("especificacionId");

                    b.HasDiscriminator().HasValue("Refresco");
                });

            modelBuilder.Entity("ClientePedido", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Cliente", null)
                        .WithMany()
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaTIC.App.Dominio.Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LineaDeProductoPedido", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.LineaDeProducto", null)
                        .WithMany()
                        .HasForeignKey("LineaDeProductosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaTIC.App.Dominio.Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.CarritoDeCompra", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Pedido", "pedido")
                        .WithMany()
                        .HasForeignKey("pedidoId");

                    b.Navigation("pedido");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Cliente", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.FormaDePago", "formaDePago")
                        .WithMany()
                        .HasForeignKey("formaDePagoId");

                    b.Navigation("formaDePago");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Envio", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Envio", "envio")
                        .WithMany()
                        .HasForeignKey("envioId");

                    b.HasOne("PizzaTIC.App.Dominio.Pago", "pago")
                        .WithMany()
                        .HasForeignKey("pagoId");

                    b.Navigation("envio");

                    b.Navigation("pago");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Ingrediente", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Hamburgesa", null)
                        .WithMany("Ingredientes")
                        .HasForeignKey("HamburgesaId");

                    b.HasOne("PizzaTIC.App.Dominio.Pastel", null)
                        .WithMany("Ingredientes")
                        .HasForeignKey("PastelId");

                    b.HasOne("PizzaTIC.App.Dominio.Perro", null)
                        .WithMany("Ingredientes")
                        .HasForeignKey("PerroId");

                    b.HasOne("PizzaTIC.App.Dominio.Pizza", null)
                        .WithMany("Ingredientes")
                        .HasForeignKey("PizzaId");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.InvLineaDeProducto", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.LineaDeProducto", null)
                        .WithMany("InvLineaDeProductos")
                        .HasForeignKey("LineaDeProductoId");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.LineaDeProducto", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.CarritoDeCompra", "carritoDeCompra")
                        .WithMany()
                        .HasForeignKey("carritoDeCompraId");

                    b.Navigation("carritoDeCompra");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pago", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.FormaDePago", "formaDePago")
                        .WithMany()
                        .HasForeignKey("formaDePagoId");

                    b.Navigation("formaDePago");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pedido", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Pago", "pago")
                        .WithMany()
                        .HasForeignKey("pagoId");

                    b.Navigation("pago");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Producto", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.LineaDeProducto", null)
                        .WithMany("Productos")
                        .HasForeignKey("LineaDeProductoId");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.InvProducto", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.InvLineaDeProducto", null)
                        .WithMany("InvProductos")
                        .HasForeignKey("InvLineaDeProductoId");

                    b.HasOne("PizzaTIC.App.Dominio.Producto", null)
                        .WithMany("InvProductos")
                        .HasForeignKey("ProductoId");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Acompanamiento", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Especificacion", "especificacion")
                        .WithMany()
                        .HasForeignKey("especificacionId");

                    b.Navigation("especificacion");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.BebidaCaliente", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Especificacion", "especificacion")
                        .WithMany()
                        .HasForeignKey("especificacionId");

                    b.Navigation("especificacion");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Galleta", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Especificacion", "especificacion")
                        .WithMany()
                        .HasForeignKey("especificacionId");

                    b.Navigation("especificacion");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Hamburgesa", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.ComidaTamano", "comidaTamano")
                        .WithMany()
                        .HasForeignKey("comidaTamanoId");

                    b.Navigation("comidaTamano");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Helado", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Especificacion", "especificacion")
                        .WithMany()
                        .HasForeignKey("especificacionId");

                    b.Navigation("especificacion");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.JugoNatural", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Especificacion", "especificacion")
                        .WithMany()
                        .HasForeignKey("especificacionId");

                    b.Navigation("especificacion");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pastel", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.ComidaTamano", "comidaTamano")
                        .WithMany()
                        .HasForeignKey("comidaTamanoId");

                    b.Navigation("comidaTamano");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Perro", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.ComidaTamano", "comidaTamano")
                        .WithMany()
                        .HasForeignKey("comidaTamanoId");

                    b.Navigation("comidaTamano");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pizza", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.ComidaTamano", "comidaTamano")
                        .WithMany()
                        .HasForeignKey("comidaTamanoId");

                    b.Navigation("comidaTamano");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Postre", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Especificacion", "especificacion")
                        .WithMany()
                        .HasForeignKey("especificacionId");

                    b.Navigation("especificacion");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Refresco", b =>
                {
                    b.HasOne("PizzaTIC.App.Dominio.Especificacion", "especificacion")
                        .WithMany()
                        .HasForeignKey("especificacionId");

                    b.Navigation("especificacion");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.InvLineaDeProducto", b =>
                {
                    b.Navigation("InvProductos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.LineaDeProducto", b =>
                {
                    b.Navigation("InvLineaDeProductos");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Producto", b =>
                {
                    b.Navigation("InvProductos");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Hamburgesa", b =>
                {
                    b.Navigation("Ingredientes");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pastel", b =>
                {
                    b.Navigation("Ingredientes");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Perro", b =>
                {
                    b.Navigation("Ingredientes");
                });

            modelBuilder.Entity("PizzaTIC.App.Dominio.Pizza", b =>
                {
                    b.Navigation("Ingredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
