using System.ComponentModel.DataAnnotations;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>CarritoDeCompra</c>
     /// Modela una CarritoDeCompra en general en el sistema 
     /// </summary>   
    public class CarritoDeCompra
    {
        // Identificador único de cada CarritoDeCompra
        public int Id { get; set; }
        [MaxLength(30)]
        public DateTime? FechaDeCreacion { get; set; }
        //Relacion de associacion CarritoDeCompra-Pedido
        public Pedido? pedido { set; get; } 
    }
}