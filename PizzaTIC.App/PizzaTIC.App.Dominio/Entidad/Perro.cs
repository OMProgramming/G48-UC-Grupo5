using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Perro</c>
     /// Modela una Perro en general en el sistema 
     /// </summary>   
    public class Perro
    {
        // Identificador único de cada Perro
        public int Id { get; set; }
        //Relacion de associacion de muchos Perros a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? PerroNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? PerroDescripcion { get; set; }       
        //Relacion de associacion Perro-Ingrediente
        public ICollection<Ingrediente>? Ingredientes { set; get; }
        //Relacion de associacion Perro-ComidaTamano
        public ComidaTamano? comidaTamano { set; get; }
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }  
    }
}