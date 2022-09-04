using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Pastel</c>
     /// Modela una Pastel en general en el sistema 
     /// </summary>   
    public class Pastel
    {
        // Identificador único de cada Pastel
        public int Id { get; set; }
        //Relacion de associacion de muchos Pasteles a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? PastelNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? PastelDescripcion { get; set; }       
        //Relacion de associacion Pastel-Ingrediente
        public ICollection<Ingrediente>? Ingredientes { set; get; }
        //Relacion de associacion Pastel-ComidaTamano
        public ComidaTamano? comidaTamano { set; get; }
        //Nombre del combo al que pertenece
        public String? Combo { get; set; } 
    }
}