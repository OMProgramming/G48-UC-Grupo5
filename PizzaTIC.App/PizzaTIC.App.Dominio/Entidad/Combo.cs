using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Combo</c>
     /// Modela una Combo en general en el sistema 
     /// </summary>   
    public class Combo
    {
        // Identificador único de cada Pizza
        public int Id { get; set; }
        //Relacion de associacion de muchas Pizzas a muchos INVProductos 
        public ICollection<InvProducto>? InvProductos { get; set; }
        [Required]
        [MaxLength(20)]
        public String? ComboNombre { get; set; }
        [Required]
        [MaxLength(60)]
        public String? ComboDescripcion { get; set; }       
        //Relacion de associacion muchos Combos a muchas Pizzas
        public ICollection<Pizza>? Pizzas { set; get; }
        //Relacion de associacion muchos Combos a muchas Hamburgesas
        public ICollection<Hamburgesa>? Hamburgesas { set; get; }
        //Relacion de associacion muchos Combos a muchas Perros
        public ICollection<Perro>? Perros { set; get; }
        //Relacion de associacion muchos Combos a muchas Pastels
        public ICollection<Pastel>? Pastels { set; get; }
        //Relacion de associacion muchos Combos a muchas Acompañantes
        public ICollection<Acompanamiento>? Acompanamientos { set; get; }
        //Relacion de associacion muchos Combos a muchas JugoNaturals
        public ICollection<JugoNatural>? JugoNaturals { set; get; }
        //Relacion de associacion muchos Combos a muchas Refrescos
        public ICollection<Refresco>? Refrescos { set; get; }
        //Relacion de associacion muchos Combos a muchas BedidasCalientes
        public ICollection<BebidaCaliente>? BebidaCalientes { set; get; }
        //Relacion de associacion muchos Combos a muchas Postres
        public ICollection<Postre>? Postres { set; get; }
        //Relacion de associacion muchos Combos a muchas Helados
        public ICollection<Helado>? Helados { set; get; }
        //Relacion de associacion muchos Combos a muchas Galletas
        public ICollection<Galleta>? Galletas { set; get; }
        
    }
}