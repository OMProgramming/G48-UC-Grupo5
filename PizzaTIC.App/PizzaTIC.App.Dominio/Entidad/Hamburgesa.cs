using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Hamburgesa</c>
     /// Modela una Hamburgesa en general en el sistema 
     /// </summary>   
    public class Hamburgesa
    {
        // Identificador único de cada Hamburgesa
        public int Id { get; set; }
        //Relacion de associacion de muchas Haburgesas a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? HamburgesaNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? HamburgesaDescripcion { get; set; }       
        //Relacion de associacion Hamburgesa-Ingrediente
        public ICollection<Ingrediente>? Ingredientes { set; get; }
        //Relacion de associacion Hamburgesa-ComidaTamano
        public ComidaTamano? comidaTamano { set; get; }
        //Nombre del combo al que pertenece
        public String? Combo { get; set; }  

    }
}