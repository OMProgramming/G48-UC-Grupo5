using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Helado</c>
     /// Modela una Helado en general en el sistema 
     /// </summary>   
    public class Helado
    {
        // Identificador único de cada Helado
        public int Id { get; set; }
        //Relacion de associacion de muchos Helados a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? HeladoNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? HeladoDescripcion { get; set; }
        //Relacion de associacion Helado-Especificacion
        public Especificacion? especificacion { set; get; } 
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }          
    }
}