using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>LineaDeProducto</c>
     /// Modela una LineaDeProducto ordenada en general en el sistema 
     /// </summary>   
    public class LineaDeProducto
    {
        // Identificador único de cada LineaDeProducto ordenada
        public int Id { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioLP { get; set; }
        //Relacion de associacion LineDeProducto-CarritoDeCompra
        public CarritoDeCompra? carritoDeCompra { set; get; }
        //Relacion de associacion muchas LineaDeProducto- a muchas InvLineaDeProducto
        public ICollection<InvLineaDeProducto>? InvLineaDeProductos { set; get; }
        //Relacion de associacion LineDeProducto- muchos Productos
        public ICollection<Producto>? Productos { set; get; }
        //Relacion de associacion de muchas LineaDeProducto a muchos Pedidos
        public ICollection<Pedido>? Pedidos { get; set; }
    }
}