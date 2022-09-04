using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Pizza</c>
     /// Modela una Pizza en general en el sistema 
     /// </summary>   
    public class Pizza
    {
        // Identificador único de cada Pizza
        public int Id { get; set; }
        //Relacion de associacion de muchas Pizzas a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? PizzaNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? PizzaDescripcion { get; set; }       
        //Relacion de associacion muchas Pizzas a muchos Ingredientes
        public ICollection<Ingrediente>? Ingredientes { set; get; }
        //Relacion de associacion Pizza-ComidaTamano
        public ComidaTamano? comidaTamano { set; get; }
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }  
       
    }
}