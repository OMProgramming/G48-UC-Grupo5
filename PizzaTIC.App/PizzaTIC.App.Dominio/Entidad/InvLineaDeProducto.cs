using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Text.Json.Serialization;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>InvLineaDeProducto</c>
     /// Modela una InvLineaDeProducto en general en el sistema 
     /// </summary>   
    public class InvLineaDeProducto
    {
        // Identificador único de cada InvLineaDeProducto
        public int Id { get; set; }
        [Required]
        [MaxLength(3)]
        public String? INVLPCodigo { get; set; }
        [Required]
        [MaxLength(30)]
        public String? INVLPNombre { get; set; }
        //Relacion de associacion InvLineaDeProducto- a muchos InvProducto
        [JsonIgnore]
        public ICollection<InvProducto>? InvProductos { set; get; }
    }
}