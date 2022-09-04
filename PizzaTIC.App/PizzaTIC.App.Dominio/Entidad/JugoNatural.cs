using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>JugoNatural</c>
     /// Modela una JugoNatural en general en el sistema 
     /// </summary>   
    public class JugoNatural
    {
        // Identificador único de cada JugoNatural
        public int Id { get; set; }
        //Relacion de associacion de muchos JugosNaturales a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? JugoNaturalNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? JugoNaturalDescripcion { get; set; }
        //Relacion de associacion JugoNatural-Especificacion
        public Especificacion? especificacion { set; get; }
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }             
    }
}