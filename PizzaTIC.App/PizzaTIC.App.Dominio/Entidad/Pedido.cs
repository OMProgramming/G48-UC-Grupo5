using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Text.Json.Serialization;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Pedido</c>
     /// Modela una Pedido en general en el sistema 
     /// </summary>   
    public class Pedido
    {
        // Identificador único de cada Pedido
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public DateTime? FechaDeRealizacion { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Estado { get; set; }
        //Relacion de associacion de muchos Pedidos a muchos Clientes
        [JsonIgnore]
        public ICollection<Cliente>? Clientes { get; set; }
        //Relacion de associacion de muchos Pedidos a muchos LineaDeProducto
        [JsonIgnore]
        public ICollection<LineaDeProducto>? LineaDeProductos { get; set; }
        //Relacion de associacion Pedido-Pago
        public Pago? pago { set; get; }
    }
}