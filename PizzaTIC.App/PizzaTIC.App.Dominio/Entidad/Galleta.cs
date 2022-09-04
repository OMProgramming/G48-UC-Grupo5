using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Galleta</c>
     /// Modela una Galleta en general en el sistema 
     /// </summary>   
    public class Galleta
    {
        // Identificador único de cada Galleta
        public int Id { get; set; }
        //Relacion de associacion de muchos Helados a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? GalletaNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? GalletaDescripcion { get; set; }
        //Relacion de associacion Galleta-Especificacion
        public Especificacion? especificacion { set; get; } 
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }             
    }
}