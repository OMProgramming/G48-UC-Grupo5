using System.ComponentModel.DataAnnotations;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Acompanamiento</c>
     /// Modela una Acompanamiento en general en el sistema 
     /// </summary>   
    public class Acompanamiento
    {
        // Identificador único de cada Acompanamiento
        public int Id { get; set; }
        //Relacion de associacion de muchos Acompanamientos a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? AcompanamientoNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? AcompanamientoDescripcion { get; set; } 
        //Relacion de associacion Acompanamiento-Especificacion
        public Especificacion? especificacion { set; get; }
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }    
    }
}