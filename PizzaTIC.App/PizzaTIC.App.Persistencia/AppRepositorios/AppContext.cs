using Microsoft.EntityFrameworkCore; /*library needed for this class*/
using PizzaTIC.App.Dominio;

namespace PizzaTIC.App.Persistencia
{ /*implementation of package Persistencia*/
    public class AppContext : DbContext /*Inheritance relationship between AppContext (child) and DbContext (Parent) classes*/
    {
        public DbSet<Acompanamiento>? Acompanamientos { get; set; } /*property Acompanamiento in Domonio*/
        public DbSet<Administrador>? Administradores { get; set; } /*property Administrador in Domonio*/
        public DbSet<BebidaCaliente>? BebidasCalientes { get; set; } /*property BebidaCaliente in Domonio*/
        public DbSet<CarritoDeCompra>? CarritosDeCompras { get; set; } /*property CarritoDeCompra in Domonio*/
        public DbSet<Cliente>? Clientes { get; set; } /*property Cliente in Domonio*/
        public DbSet<Combo>? Combo { get; set; } /*property Combo in Domonio*/
        public DbSet<ComidaTamano>? ComidaTamanos { get; set; } /*property ComidaTamano in Domonio*/
        public DbSet<Envio>? Envios { get; set; } /*property Envio in Domonio*/
        public DbSet<Especificacion>? Especificaciones { get; set; } /*property Especificacion in Domonio*/
        public DbSet<FormaDePago>? FormasDePagos { get; set; } /*property FormaDePago in Domonio*/
        public DbSet<Galleta>? Galletas { get; set; } /*property Galleta in Domonio*/
        public DbSet<Hamburgesa>? Hamburgesas { get; set; } /*property Hamburgesa in Domonio*/
        public DbSet<Helado>? Helados { get; set; } /*property Helado in Domonio*/
        public DbSet<Ingrediente>? Ingredientes { get; set; } /*property Ingrediente in Domonio*/
        public DbSet<InvLineaDeProducto>? InvLineaDeProductos { get; set; } /*property InvLineaDeProducto in Domonio*/
        public DbSet<InvProducto>? InvProductos { get; set; } /*property InvProducto in Domonio*/
        public DbSet<JugoNatural>? JugosNaturales { get; set; } /*property JugoNatural in Domonio*/
        public DbSet<LineaDeProducto>? LineasDeProductos { get; set; } /*property LineaDeProducto in Domonio*/
        public DbSet<Pago>? Pagos { get; set; } /*property Pago in Domonio*/
        public DbSet<Pastel>? Pasteles { get; set; } /*property Pastel in Domonio*/
        public DbSet<Pedido>? Pedidos { get; set; } /*property Pedido in Domonio*/
        public DbSet<Perro>? Perros { get; set; } /*property Perro in Domonio*/
        public DbSet<Pizza>? Pizzas { get; set; } /*property Pizza in Domonio*/
        public DbSet<Postre>? Postres { get; set; } /*property Postre in Domonio*/
        public DbSet<Producto>? Productos { get; set; } /*property Producto in Domonio*/
        public DbSet<Refresco>? Refrescos { get; set; } /*property Refresco in Domonio*/
        /*Add all the other properties here for PizzaTIC.App.Dominio*/



        /*Use this method to create a DB with name indicated in "Initial Catalog"*/ 
        protected override void OnConfiguring (DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PizzaTICData;Trusted_Connection=True; MultipleActiveResultSets=True");
            }
        }
    }
}