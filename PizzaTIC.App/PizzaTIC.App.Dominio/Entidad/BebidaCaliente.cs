using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>BebidaCaliente</c>
     /// Modela una BebidaCaliente en general en el sistema 
     /// </summary>   
    public class BebidaCaliente
    {
        // Identificador único de cada BebidaCaliente
        public int Id { get; set; }
        //Relacion de associacion de muchos BebidasCalientes a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? BebidaCalienteoNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? BebidaCalienteDescripcion { get; set; }
        //Relacion de associacion BebidaCaliente-Especificacion
        public Especificacion? especificacion { set; get; }  
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }           
    }
}