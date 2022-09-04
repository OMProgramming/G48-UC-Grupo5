using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Text.Json.Serialization;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Ingrediente</c>
     /// Modela una Ingrediente en general en el sistema 
     /// </summary>   
    public class Ingrediente
    {
        // Identificador único de cada Ingrediente
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public String? NombreIngrediente { get; set; }
        [Required]
        [MaxLength(20)]
        public String? TipoIngrediente { get; set; }
        public int? Calorias { get; set; }
        //Relacion de associacion muchos Ingredientes a muchas Pizzas 
        [JsonIgnore]//to prevent every pizza with this tooping to be showed
        public ICollection<Pizza>? Pizzas { set; get; }
        //Relacion de associacion muchos Ingredientes a muchas Hamburgesas 
        [JsonIgnore]
        public ICollection<Hamburgesa>? Hamburgesas { set; get; }
        //Relacion de associacion muchos Ingredientes a muchos Perros 
        [JsonIgnore]
        public ICollection<Perro>? Perros { set; get; }
        //Relacion de associacion muchos Ingredientes a muchos Pastels 
        [JsonIgnore]
        public ICollection<Pastel>? Pastels { set; get; }
    }
}