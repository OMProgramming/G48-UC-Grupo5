using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Refresco</c>
     /// Modela una Refresco en general en el sistema 
     /// </summary>   
    public class Refresco
    {
        // Identificador único de cada Refresco
        public int Id { get; set; }
        //Relacion de associacion de muchos Refrescos a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? RefrescoNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? RefrescoDescripcion { get; set; }
        //Relacion de associacion Refresco-Especificacion
        public Especificacion? especificacion { set; get; } 
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }             
    }
}