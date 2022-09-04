using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Text.Json.Serialization;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>InvProducto</c>
     /// Modela una InvProducto en general en el sistema 
     /// </summary>   
    public class InvProducto
    {
        // Identificador único de cada InvProducto
        public int Id { get; set; }
        //Relacion de associacion InvProducto a InvLineaDeProducto
        public ICollection<InvLineaDeProducto>? InvLineaDeProductos { set; get; }
        [Required]
        [MaxLength(3)]
        public String? INVProductoCodigo { get; set; }
        [Required]
        [MaxLength(30)]
        public String? INVProductoNombre { get; set; }     
        [JsonIgnore]
        public ICollection<Pizza>? Pizzas { set; get; }
        //Relacion de associacion Hamburgesa-InvProducto
        [JsonIgnore]
        public ICollection<Hamburgesa>? Hamburgesas { set; get; }
        [JsonIgnore]
        //Relacion de associacion Perro-InvProducto
        public ICollection<Perro>? Perros { set; get; }
        [JsonIgnore]
        //Relacion de associacion Pastel-InvProducto
        public ICollection<Pastel>? Pasteles { set; get; }
        [JsonIgnore]
        //Relacion de associacion Acompanamiento-InvProducto
        public ICollection<Acompanamiento>? Acompanamientos  { set; get; }
        [JsonIgnore]
        //Relacion de associacion JugoNatural-InvProducto
        public ICollection<JugoNatural>? JugosNaturales { set; get; }
        [JsonIgnore]
        //Relacion de associacion Refresco-InvProducto
        public ICollection<Refresco>? Refrescos { set; get; }
        [JsonIgnore]
        //Relacion de associacion BebidaCaliente-InvProducto
        public ICollection<BebidaCaliente>? BebidasCalientes { set; get; }
        [JsonIgnore]
        //Relacion de associacion Postre-InvProducto
        public ICollection<Postre>? Postres { set; get; }
        [JsonIgnore]
        //Relacion de associacion Helado-InvProducto
        public ICollection<Helado>? Helados { set; get; }
        [JsonIgnore]
        //Relacion de associacion Galleta-InvProducto
        public ICollection<Galleta>? Galletas { set; get; }
        //Relacion de associacion Combinado-InvProducto
        public ICollection<Combo>? Combo { set; get; }
    }
}

