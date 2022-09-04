using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Producto</c>
     /// Modela una Producto ordenado en general en el sistema 
     /// </summary>   
    public class Producto
    {
        // Identificador único de cada Producto Ordenado
        public int Id { get; set; }
        //Relacion de associacion de muchos Producto- a muchos InvProducto
        public ICollection<InvProducto>? InvProductos { set; get; }
        public decimal? PrecioUnitario { set; get; }
    }
}