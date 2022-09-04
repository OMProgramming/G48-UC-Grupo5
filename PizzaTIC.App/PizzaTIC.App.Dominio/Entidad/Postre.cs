using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Postre</c>
     /// Modela una Postre en general en el sistema 
     /// </summary>   
    public class Postre
    {
        // Identificador único de cada Postre
        public int Id { get; set; }
        //Relacion de associacion de muchos Postres a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? PostreNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? PostreDescripcion { get; set; }
        //Relacion de associacion Postre-Especificacion
        public Especificacion? especificacion { set; get; } 
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }           
    }
}